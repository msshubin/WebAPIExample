using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebApiExample.Extensions;
using WebApiExample.Models;

namespace WebApiExample
{
    public partial class WebApiExampleForm : Form
    {
        private static string AuthToken { get; set; }
        private static string SessionToken { get; set; }
        private static string ElmaServer { get; set; }
        //токен приложения задается в админке ELMA
        private static readonly string appToken = "12D37077EF328E38F371E0159D28ADB6DE1C4C8C37100BADDB19CDF57BE39C682145B7BECB040842361F4F95BF77606DEF2426CE6F5B9FBF361EB82AC5AF9A6A";
        //private static readonly string appToken = "B054178B2531349D80305B0AC19D62523CD9FCB6A42BD07BB53A1F33CA76D4120018941ED6F7AC1FBD056264491069ABFE6D56F5E4B485D3B61BAC900B5D7C21";
        private static JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            DateParseHandling = DateParseHandling.DateTime,
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
        };
        private Guid GuidFile { get; set; }

        #region private Members
        /// <summary>
        /// Выполнить запрос на основании данных
        /// </summary>
        /// <param name="restData">Данные</param>
        /// <returns>Ответ сервера</returns>
        private static HttpWebResponse DoRestExecute(RestData restData, Dictionary<string, string> headers = null)
        {
            //Создаем экземпляр запроса по URL
            var HttpWReq = (HttpWebRequest)WebRequest.Create(restData.Url);

            //Указываем метод запроса
            HttpWReq.Method = restData.HTTPMethod;
            HttpWReq.Credentials = CredentialCache.DefaultCredentials;
            //Добавляем токен приложения
            HttpWReq.Headers.Add("ApplicationToken", appToken);
            //Добавляем токен авторизации, если есть
            if (!string.IsNullOrWhiteSpace(AuthToken))
            {
                HttpWReq.Headers.Add("AuthToken", AuthToken);
            }
            //Добавляем токен сессии, если есть
            if (!string.IsNullOrEmpty(SessionToken))
            {
                HttpWReq.Headers.Add("SessionToken", SessionToken);
            }
            HttpWReq.Accept = "application/json; charset=utf-8";
            HttpWReq.Headers.Add("WebData-Version", "2.0");
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    HttpWReq.Headers.Add(header.Key, header.Value);
                }
            }
            var encoding = new UTF8Encoding();

            //Если метод POST, тогда добавляем тип контента и вставляем данные
            if (restData.HTTPMethod == WebRequestMethods.Http.Post)
            {
                var byteData = encoding.GetBytes(restData.Data);
                HttpWReq.ContentType = "application/json; charset=utf-8";

                HttpWReq.ContentLength = byteData.Length;
                using (Stream requestStream = HttpWReq.GetRequestStream())
                {
                    requestStream.Write(byteData, 0, byteData.Length);
                }
            }
            return (HttpWebResponse)HttpWReq.GetResponse();
        }

        /// <summary>
        /// Выполнить запрос
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="url">URL</param>
        /// <param name="requestData">Сериализованные данные</param>
        /// <param name="httpMethod">Метод запроса (post, get)</param>
        /// <returns>Десериализованный ответ с сервера</returns>
        private T RestExecute<T>(string url, object requestData, string httpMethod, Dictionary<string, string> addHeaders = null)
        {
            var serializedObject = JsonConvert.SerializeObject(requestData, new HttpPostedFileConverter());
            debugView.AppendText(Environment.NewLine);
            debugView.AppendText("Сериализованные данные запроса: " + serializedObject, Color.Green);
            var g = new RestData(url, serializedObject, httpMethod);
            HttpWebResponse httpWResp = null;
            try
            {
                httpWResp = DoRestExecute(g, addHeaders);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Response);
            }

            var result = "";
            if (httpWResp != null && httpWResp.StatusCode == HttpStatusCode.OK)
            {
                using (var sr = new StreamReader(httpWResp.GetResponseStream()))
                {
                    result = sr.ReadToEnd();

                    debugView.AppendText(Environment.NewLine);
                    debugView.AppendText(string.Format("Ответ сервера: {0}", result), Color.Black);
                    debugView.AppendText(Environment.NewLine);
                }
            }
            else
            {
                if (httpWResp != null)
                    Console.WriteLine("ERROR STATUS CODE:{0}, MESSAGE: {1}", httpWResp.StatusCode,
                        httpWResp.StatusDescription);
                else
                {
                    debugView.AppendText(Environment.NewLine);
                    debugView.AppendText("Ошибка при выполнении запроса", Color.Red);
                    debugView.AppendText(Environment.NewLine);
                    //throw new WebException("httpWResp == null");
                }
            }
            return JsonConvert.DeserializeObject<T>(result, JsonSettings);
        }

        /// <summary>
        /// Функция получения статуса сервера
        /// </summary>
        /// <returns>Статус сервера 1, 2, 3</returns>
        private string GetServerStatus(out string reason)
        {
            reason = string.Empty;
            //Отправляем запрос на сервер для получения статуса
            var httpWReq = (HttpWebRequest)WebRequest.Create(string.Format("{0}StartInfoHandler.ashx?type=StartInfo", ElmaServer));
            var response = httpWReq.GetResponse();
            string result = string.Empty;
            string stringResponse;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                stringResponse = sr.ReadToEnd();
            }
            if (!string.IsNullOrWhiteSpace(stringResponse))
                result = stringResponse.Substring(0, 1);
            while (result == "0")
            {
                System.Threading.Thread.Sleep(1000);
                result = GetServerStatus(out reason);
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Сервер запускается", Color.Green);
                debugView.AppendText(Environment.NewLine);
            }
            if (result == "3")
            {
                var index = stringResponse.LastIndexOf(";");
                reason = stringResponse.Substring(index, stringResponse.Length - index);
            }

            return result;
        }
        #endregion

        #region RestFunctions

        /// <summary>
        /// ELMA Авторизация REST
        /// </summary>
        private Auth Authorization(string login, string password)
        {
            var urlAuth = string.Format("{0}/API/REST/Authorization/LoginWith?username={1}", ElmaServer, login);
            return RestExecute<Auth>(urlAuth, password, WebRequestMethods.Http.Post);
        }

        /// <summary>
        /// Запуск процесса
        /// </summary>
        /// <returns>Токен выполнения задачи ExecutionToken</returns>
        private WorkflowStartProcessModelResult StartProcess()
        {
            //токен процесса 93e53723-a86c-45f9-81dc-27c3a091e984
/*            
            var arr = new List<object>();
            arr.Add(new {
                    Stroka = "111",
                    Fayl = new { Uid = GuidFile }
                    });
            arr.Add(new {
                    Stroka = "222",
                    //Fayl = "ss"
                    });
                    */

            //Задаем контекст
            var context = new
            {
                Stroka = "Простая строка",
                File = new { Uid = GuidFile }
            };

            var process = new WorkflowStartProcessModel
            {
                ProcessToken = tbToken.Text,
                ProcessName = tbProcessName.Text,
                Context = context
            };

            var startProcessAsyncReq = string.Format("{0}API/REST/Workflow/StartProcessAsync", ElmaServer);
            return RestExecute<WorkflowStartProcessModelResult>(startProcessAsyncReq, process, WebRequestMethods.Http.Post);
        }

        private Guid UploadFile(Stream fileStream, string fileName)
        {
            var uploadFileReq = string.Format("{0}API/REST/Files/Upload", ElmaServer);
            var headers = new Dictionary<string, string>();
            headers["FileName"] = HttpUtility.UrlEncode(fileName);
            return RestExecute<Guid>(uploadFileReq, fileStream, WebRequestMethods.Http.Post, headers);
        }
        
        #endregion

        public WebApiExampleForm()
        {
            InitializeComponent();
        }

        private void checkServer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(urlServer.Text))
            {
                ElmaServer = string.Format("http://{0}/", urlServer.Text);

                string reason;

                //Получаем статус сервера
                var status = GetServerStatus(out reason);

                //Проверяем значение статуса
                switch (status)
                {
                    //Если приложение запущено
                    case "1":
                        var url = String.Format("{0}API/REST/Authorization/Version", ElmaServer);
                        var version = RestExecute<string>(url, "", WebRequestMethods.Http.Get);
                        if (!string.IsNullOrWhiteSpace(version))
                        {
                            debugView.AppendText(string.Format("Текущая версия сервера : {0}", version), Color.Green);
                            debugView.AppendText(Environment.NewLine);
                            gbAuthorization.Enabled = true;
                        }
                        break;
                    case "2":
                        debugView.AppendText(Environment.NewLine);
                        debugView.AppendText("Приложение не активировано", Color.Red);
                        debugView.AppendText(Environment.NewLine);
                        break;
                    case "3":
                        debugView.AppendText(Environment.NewLine);
                        debugView.AppendText("Приложение не запущено (Ошибка запуска)", Color.Red);
                        debugView.AppendText(Environment.NewLine);
                        break;
                }
            }
            else
            {
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Url сервера не заполнен", Color.Red);
                debugView.AppendText(Environment.NewLine);
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            //Авторизуемся + получаем токен
            var auth = Authorization(login.Text, password.Text);
            if (auth != null)
            {
                AuthToken = auth.AuthToken;
                if (string.IsNullOrWhiteSpace(SessionToken))
                    SessionToken = auth.SessionToken;
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Авторизация прошла успешно", Color.Green);
                debugView.AppendText(Environment.NewLine);
                tcApi.Enabled = true;
            }
            else
            {
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Ошибка авторизации", Color.Red);
                debugView.AppendText(Environment.NewLine);
            }
        }

        private void bStartProcess_Click(object sender, EventArgs e)
        {
            var startProcessAsyncRes = StartProcess();
            if (startProcessAsyncRes != null)
            {
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Процесс запущен успешно", Color.Green);
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText(string.Format("Статус процесса: {0}", startProcessAsyncRes.Status), Color.Green);
                debugView.AppendText(Environment.NewLine);
                if (startProcessAsyncRes.Result)
                {
                    debugView.AppendText(
                        string.Format("Токен запуска процесса: {0}", startProcessAsyncRes.ExecutionToken), Color.Green);
                }
            }
            else
            {
                debugView.AppendText(Environment.NewLine);
                debugView.AppendText("Ошибка запуска процесса", Color.Red);
                debugView.AppendText(Environment.NewLine);
            }
        }

        private void bChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(openFileDialog1.FileName, FileMode.Open);
                var lastIndexOfSlash = file.Name.LastIndexOf('\\');
                var filename = file.Name.Substring(lastIndexOfSlash + 1, file.Name.Length - lastIndexOfSlash - 1);
                GuidFile = UploadFile(file, filename);
                file.Close();
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (rMeeting.Checked)
            {
                var url = String.Format("{0}API/REST/BatchOperation/Query", ElmaServer);
                var listQuery = new List<EntityQueryRequest>();
                var query = new EntityQueryRequest
                {
                    TypeUid = new Guid("ef672d2c-1d14-40d3-b2ac-b132a02c1b6d"),
                    EQLQuery = "Id=" + tbEntityId.Text,
                    Select = "Theme,StartDate,EndDate,Description,Priority,Contractor/Uid,"
                };
                var query2 = new EntityQueryRequest
                {
                    TypeUid = new Guid("ef672d2c-1d14-40d3-b2ac-b132a02c1b6d"),
                    EQLQuery = "Id=" + tbEntityId.Text,
                    Select = "Theme,StartDate,EndDate,Description,Priority,Contractor/Uid,"
                };
                listQuery.Add(query);
                listQuery.Add(query2);

                var query1 = RestExecute<List<EntityQueryRequest>>(url, listQuery, WebRequestMethods.Http.Post);
            }
            if (rMail.Checked)
            {
                var select = "Theme,StartDate,EndDate,Description,Priority,Contractor/Uid,Contact/Uid,Lead/Uid,RelationshipUsers/Status,RelationshipUsers/User/Uid";

                var url = String.Format("{0}/API/REST/Entity/LoadTree?type={1}&id={2}&select={3}", ElmaServer, new Guid("bed7fd63-a906-44ea-929a-2b085c8edfc9"), tbEntityId.Text, select);
                
                var mail = RestExecute<RelationshipMail>(url, "", WebRequestMethods.Http.Get);
            }
        }

        private void bCreateEntity_Click(object sender, EventArgs e)
        {
            if (rMeeting.Checked)
                CreateMeeting();
            if (rCall.Checked)
                CreateCall();
            if (rMail.Checked)
                CreateMail();
        }

        private RelationshipPriority GetPriority(int index)
        {
            switch (index)
            {
                case 1:
                    return RelationshipPriority.High;
                case 2:
                    return RelationshipPriority.Medium;
                case 3:
                    return RelationshipPriority.Low;
                default:
                    return RelationshipPriority.High;
            }
        }

        private void CreateMeeting()
        {
            var url = String.Format("{0}/API/REST/Entity/Insert/{1}", ElmaServer, new Guid("ef672d2c-1d14-40d3-b2ac-b132a02c1b6d"));
            
            var meeting = new RelationshipMeeting
            {
                Theme = tTheme.Text,
                StartDate = dStartDate.Value,
                EndDate = dEndDate.Value,
                Place = tPlace.Text,
                TimeNotSet = cbTimeNotSet.Checked,
                Priority = GetPriority(cbPriority.SelectedIndex + 1),
                RelationshipUsers = GetRelationshipUsers()
            };

            meeting = (RelationshipMeeting)GetWhom(meeting);

            var entityId = RestExecute<string>(url, meeting, WebRequestMethods.Http.Post);
            tbEntityId.Text = entityId;
            debugView.AppendText(Environment.NewLine);
            debugView.AppendText("Идентификатор встречи: " + entityId, Color.Green);
            debugView.AppendText(Environment.NewLine);
        }
        
        private void CreateCall()
        {
            var url = String.Format("{0}/API/REST/Entity/Insert/{1}", ElmaServer, new Guid("cdf8842c-3733-43e9-8c55-f74196179a0c"));

            var call = new RelationshipCall
            {
                Theme = tTheme.Text,
                StartDate = dStartDate.Value,
                EndDate = dEndDate.Value,
                Type = RelationshipCallType.Output,
                Priority = GetPriority(cbPriority.SelectedIndex + 1),
                RelationshipUsers = GetRelationshipUsers()
            };

            call = (RelationshipCall)GetWhom(call);
            
            var entityId = RestExecute<string>(url, call, WebRequestMethods.Http.Post);
            tbEntityId.Text = entityId;
            debugView.AppendText(Environment.NewLine);
            debugView.AppendText("Идентификатор звонка: " + entityId, Color.Green);
            debugView.AppendText(Environment.NewLine);
        }

        private void CreateMail()
        {
            var url = String.Format("{0}API/REST/Entity/Insert/{1}", ElmaServer, new Guid("bed7fd63-a906-44ea-929a-2b085c8edfc9"));

            var mail = new RelationshipMail
            {
                Theme = tTheme.Text,
                StartDate = dStartDate.Value,
                EndDate = dEndDate.Value,
                Priority = GetPriority(cbPriority.SelectedIndex + 1),
                RelationshipUsers = GetRelationshipUsers()
            };

            mail = (RelationshipMail) GetWhom(mail);

            var entityId = RestExecute<string>(url, mail, WebRequestMethods.Http.Post);
            tbEntityId.Text = entityId;
            debugView.AppendText(Environment.NewLine);
            debugView.AppendText("Идентификатор письма: " + entityId, Color.Green);
            debugView.AppendText(Environment.NewLine);
        }

        private List<RelationshipUser> GetRelationshipUsers()
        {
            var listUsers = new List<RelationshipUser>();
            var user = new RelationshipUser
            {
                TypeUid = new Guid("2c32f760-b2a4-4bcf-a842-bfcc6721775c"),
                User = new User
                {
                    Id = 1
                },
                Status = RelationshipUserStatus.Participant
            };
            listUsers.Add(user);
            return listUsers;
        }

        private Relationship GetWhom(Relationship relationship)
        {
            if (rContact.Checked)
            {
                relationship.Contact = new Contact
                {
                    TypeUid = new Guid("73bf0874-4f9d-4e5a-a1f9-0b44c9a5aa88"),
                    Id = long.Parse(tbEntityId2.Text)
                };
            }
            if (rLead.Checked)
            {
                relationship.Lead = new Lead
                {
                    TypeUid = new Guid("3744e860-7268-4b70-a32a-597d59fcfeea"),
                    Id = long.Parse(tbEntityId2.Text)
                };
            }
            if (rContractor.Checked)
            {
                relationship.Contractor = new Contractor
                {
                    //TypeUid = new Guid("1fb7545c-b103-44b1-9b01-dacb986db75d"),
                    //Name = "contr",
                    Id = long.Parse(tbEntityId2.Text)
                };
            }
            return relationship;
        }

        private void tbToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void debugView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
