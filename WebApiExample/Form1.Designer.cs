namespace WebApiExample
{
    partial class WebApiExampleForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlServer = new System.Windows.Forms.TextBox();
            this.urlServerLabel = new System.Windows.Forms.Label();
            this.gbMainInfo = new System.Windows.Forms.GroupBox();
            this.checkServer = new System.Windows.Forms.Button();
            this.debugView = new System.Windows.Forms.RichTextBox();
            this.gbAuthorization = new System.Windows.Forms.GroupBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.tcApi = new System.Windows.Forms.TabControl();
            this.tpStartProcess = new System.Windows.Forms.TabPage();
            this.gbStartProcess = new System.Windows.Forms.GroupBox();
            this.bChooseFile = new System.Windows.Forms.Button();
            this.lProcessName = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.bStartProcess = new System.Windows.Forms.Button();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.lToken = new System.Windows.Forms.Label();
            this.tpTree = new System.Windows.Forms.TabPage();
            this.gbTree = new System.Windows.Forms.GroupBox();
            this.gbWhom = new System.Windows.Forms.GroupBox();
            this.rLead = new System.Windows.Forms.RadioButton();
            this.rContact = new System.Windows.Forms.RadioButton();
            this.rContractor = new System.Windows.Forms.RadioButton();
            this.lEntityId2 = new System.Windows.Forms.Label();
            this.tbEntityId2 = new System.Windows.Forms.TextBox();
            this.lPriority = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbTimeNotSet = new System.Windows.Forms.CheckBox();
            this.lPlace = new System.Windows.Forms.Label();
            this.tPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dEndDate = new System.Windows.Forms.DateTimePicker();
            this.dStartDate = new System.Windows.Forms.DateTimePicker();
            this.lStartDate = new System.Windows.Forms.Label();
            this.lTheme = new System.Windows.Forms.Label();
            this.tTheme = new System.Windows.Forms.TextBox();
            this.bCreateEntity = new System.Windows.Forms.Button();
            this.rCall = new System.Windows.Forms.RadioButton();
            this.rMeeting = new System.Windows.Forms.RadioButton();
            this.rMail = new System.Windows.Forms.RadioButton();
            this.bLoad = new System.Windows.Forms.Button();
            this.tbEntityId = new System.Windows.Forms.TextBox();
            this.lEntityId = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMainInfo.SuspendLayout();
            this.gbAuthorization.SuspendLayout();
            this.tcApi.SuspendLayout();
            this.tpStartProcess.SuspendLayout();
            this.gbStartProcess.SuspendLayout();
            this.tpTree.SuspendLayout();
            this.gbTree.SuspendLayout();
            this.gbWhom.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlServer
            // 
            this.urlServer.Location = new System.Drawing.Point(94, 19);
            this.urlServer.Name = "urlServer";
            this.urlServer.Size = new System.Drawing.Size(167, 20);
            this.urlServer.TabIndex = 0;
            this.urlServer.Text = "localhost:8000";
            // 
            // urlServerLabel
            // 
            this.urlServerLabel.AutoSize = true;
            this.urlServerLabel.Location = new System.Drawing.Point(6, 22);
            this.urlServerLabel.Name = "urlServerLabel";
            this.urlServerLabel.Size = new System.Drawing.Size(65, 13);
            this.urlServerLabel.TabIndex = 1;
            this.urlServerLabel.Text = "Url сервера";
            // 
            // gbMainInfo
            // 
            this.gbMainInfo.Controls.Add(this.checkServer);
            this.gbMainInfo.Controls.Add(this.urlServer);
            this.gbMainInfo.Controls.Add(this.urlServerLabel);
            this.gbMainInfo.Location = new System.Drawing.Point(12, 12);
            this.gbMainInfo.Name = "gbMainInfo";
            this.gbMainInfo.Size = new System.Drawing.Size(272, 80);
            this.gbMainInfo.TabIndex = 2;
            this.gbMainInfo.TabStop = false;
            this.gbMainInfo.Text = "Информация о сервере";
            // 
            // checkServer
            // 
            this.checkServer.Location = new System.Drawing.Point(94, 45);
            this.checkServer.Name = "checkServer";
            this.checkServer.Size = new System.Drawing.Size(167, 23);
            this.checkServer.TabIndex = 3;
            this.checkServer.Text = "Проверка";
            this.checkServer.UseVisualStyleBackColor = true;
            this.checkServer.Click += new System.EventHandler(this.checkServer_Click);
            // 
            // debugView
            // 
            this.debugView.Location = new System.Drawing.Point(8, 430);
            this.debugView.Name = "debugView";
            this.debugView.Size = new System.Drawing.Size(838, 202);
            this.debugView.TabIndex = 3;
            this.debugView.Text = "";
            this.debugView.TextChanged += new System.EventHandler(this.debugView_TextChanged);
            // 
            // gbAuthorization
            // 
            this.gbAuthorization.Controls.Add(this.lPassword);
            this.gbAuthorization.Controls.Add(this.password);
            this.gbAuthorization.Controls.Add(this.bLogin);
            this.gbAuthorization.Controls.Add(this.login);
            this.gbAuthorization.Controls.Add(this.lLogin);
            this.gbAuthorization.Enabled = false;
            this.gbAuthorization.Location = new System.Drawing.Point(12, 98);
            this.gbAuthorization.Name = "gbAuthorization";
            this.gbAuthorization.Size = new System.Drawing.Size(272, 100);
            this.gbAuthorization.TabIndex = 4;
            this.gbAuthorization.TabStop = false;
            this.gbAuthorization.Text = "Авторизация";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(6, 48);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(94, 45);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 20);
            this.password.TabIndex = 4;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(94, 71);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(167, 23);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(94, 19);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(167, 20);
            this.login.TabIndex = 0;
            this.login.Text = "admin";
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(6, 22);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(38, 13);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Логин";
            // 
            // tcApi
            // 
            this.tcApi.Controls.Add(this.tpStartProcess);
            this.tcApi.Controls.Add(this.tpTree);
            this.tcApi.Enabled = false;
            this.tcApi.Location = new System.Drawing.Point(302, 13);
            this.tcApi.Name = "tcApi";
            this.tcApi.SelectedIndex = 0;
            this.tcApi.Size = new System.Drawing.Size(548, 411);
            this.tcApi.TabIndex = 5;
            // 
            // tpStartProcess
            // 
            this.tpStartProcess.Controls.Add(this.gbStartProcess);
            this.tpStartProcess.Location = new System.Drawing.Point(4, 22);
            this.tpStartProcess.Name = "tpStartProcess";
            this.tpStartProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tpStartProcess.Size = new System.Drawing.Size(540, 385);
            this.tpStartProcess.TabIndex = 0;
            this.tpStartProcess.Text = "Запуск процесса";
            this.tpStartProcess.UseVisualStyleBackColor = true;
            // 
            // gbStartProcess
            // 
            this.gbStartProcess.Controls.Add(this.bChooseFile);
            this.gbStartProcess.Controls.Add(this.lProcessName);
            this.gbStartProcess.Controls.Add(this.tbProcessName);
            this.gbStartProcess.Controls.Add(this.bStartProcess);
            this.gbStartProcess.Controls.Add(this.tbToken);
            this.gbStartProcess.Controls.Add(this.lToken);
            this.gbStartProcess.Location = new System.Drawing.Point(3, 3);
            this.gbStartProcess.Name = "gbStartProcess";
            this.gbStartProcess.Size = new System.Drawing.Size(434, 231);
            this.gbStartProcess.TabIndex = 5;
            this.gbStartProcess.TabStop = false;
            this.gbStartProcess.Text = "Запуск процесса";
            // 
            // bChooseFile
            // 
            this.bChooseFile.Location = new System.Drawing.Point(101, 68);
            this.bChooseFile.Name = "bChooseFile";
            this.bChooseFile.Size = new System.Drawing.Size(118, 23);
            this.bChooseFile.TabIndex = 6;
            this.bChooseFile.Text = "Выбрать файл";
            this.bChooseFile.UseVisualStyleBackColor = true;
            this.bChooseFile.Click += new System.EventHandler(this.bChooseFile_Click);
            // 
            // lProcessName
            // 
            this.lProcessName.AutoSize = true;
            this.lProcessName.Location = new System.Drawing.Point(6, 48);
            this.lProcessName.Name = "lProcessName";
            this.lProcessName.Size = new System.Drawing.Size(80, 13);
            this.lProcessName.TabIndex = 5;
            this.lProcessName.Text = "Имя процесса";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(101, 45);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(167, 20);
            this.tbProcessName.TabIndex = 4;
            // 
            // bStartProcess
            // 
            this.bStartProcess.Location = new System.Drawing.Point(101, 99);
            this.bStartProcess.Name = "bStartProcess";
            this.bStartProcess.Size = new System.Drawing.Size(167, 23);
            this.bStartProcess.TabIndex = 3;
            this.bStartProcess.Text = "Запустить процесс";
            this.bStartProcess.UseVisualStyleBackColor = true;
            this.bStartProcess.Click += new System.EventHandler(this.bStartProcess_Click);
            // 
            // tbToken
            // 
            this.tbToken.Location = new System.Drawing.Point(101, 19);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(167, 20);
            this.tbToken.TabIndex = 0;
            this.tbToken.Text = "e627f4be-aaa7-4ea7-94d9-32f859ef0dac";
            this.tbToken.TextChanged += new System.EventHandler(this.tbToken_TextChanged);
            // 
            // lToken
            // 
            this.lToken.AutoSize = true;
            this.lToken.Location = new System.Drawing.Point(6, 22);
            this.lToken.Name = "lToken";
            this.lToken.Size = new System.Drawing.Size(89, 13);
            this.lToken.TabIndex = 1;
            this.lToken.Text = "Токен процесса";
            // 
            // tpTree
            // 
            this.tpTree.Controls.Add(this.gbTree);
            this.tpTree.Location = new System.Drawing.Point(4, 22);
            this.tpTree.Name = "tpTree";
            this.tpTree.Size = new System.Drawing.Size(540, 385);
            this.tpTree.TabIndex = 1;
            this.tpTree.Text = "Операции с контрагентами";
            this.tpTree.UseVisualStyleBackColor = true;
            // 
            // gbTree
            // 
            this.gbTree.Controls.Add(this.gbWhom);
            this.gbTree.Controls.Add(this.lPriority);
            this.gbTree.Controls.Add(this.cbPriority);
            this.gbTree.Controls.Add(this.cbTimeNotSet);
            this.gbTree.Controls.Add(this.lPlace);
            this.gbTree.Controls.Add(this.tPlace);
            this.gbTree.Controls.Add(this.label1);
            this.gbTree.Controls.Add(this.dEndDate);
            this.gbTree.Controls.Add(this.dStartDate);
            this.gbTree.Controls.Add(this.lStartDate);
            this.gbTree.Controls.Add(this.lTheme);
            this.gbTree.Controls.Add(this.tTheme);
            this.gbTree.Controls.Add(this.bCreateEntity);
            this.gbTree.Controls.Add(this.rCall);
            this.gbTree.Controls.Add(this.rMeeting);
            this.gbTree.Controls.Add(this.rMail);
            this.gbTree.Controls.Add(this.bLoad);
            this.gbTree.Controls.Add(this.tbEntityId);
            this.gbTree.Controls.Add(this.lEntityId);
            this.gbTree.Location = new System.Drawing.Point(3, 3);
            this.gbTree.Name = "gbTree";
            this.gbTree.Size = new System.Drawing.Size(525, 379);
            this.gbTree.TabIndex = 6;
            this.gbTree.TabStop = false;
            this.gbTree.Text = "LoadTree";
            // 
            // gbWhom
            // 
            this.gbWhom.Controls.Add(this.rLead);
            this.gbWhom.Controls.Add(this.rContact);
            this.gbWhom.Controls.Add(this.rContractor);
            this.gbWhom.Controls.Add(this.lEntityId2);
            this.gbWhom.Controls.Add(this.tbEntityId2);
            this.gbWhom.Location = new System.Drawing.Point(9, 175);
            this.gbWhom.Name = "gbWhom";
            this.gbWhom.Size = new System.Drawing.Size(510, 72);
            this.gbWhom.TabIndex = 22;
            this.gbWhom.TabStop = false;
            this.gbWhom.Text = "Кому";
            // 
            // rLead
            // 
            this.rLead.AutoSize = true;
            this.rLead.Location = new System.Drawing.Point(164, 19);
            this.rLead.Name = "rLead";
            this.rLead.Size = new System.Drawing.Size(144, 17);
            this.rLead.TabIndex = 12;
            this.rLead.Text = "Потенциальный клиент";
            this.rLead.UseVisualStyleBackColor = true;
            // 
            // rContact
            // 
            this.rContact.AutoSize = true;
            this.rContact.Location = new System.Drawing.Point(92, 19);
            this.rContact.Name = "rContact";
            this.rContact.Size = new System.Drawing.Size(66, 17);
            this.rContact.TabIndex = 11;
            this.rContact.Text = "Контакт";
            this.rContact.UseVisualStyleBackColor = true;
            // 
            // rContractor
            // 
            this.rContractor.AutoSize = true;
            this.rContractor.Checked = true;
            this.rContractor.Location = new System.Drawing.Point(9, 19);
            this.rContractor.Name = "rContractor";
            this.rContractor.Size = new System.Drawing.Size(83, 17);
            this.rContractor.TabIndex = 10;
            this.rContractor.TabStop = true;
            this.rContractor.Text = "Контрагент";
            this.rContractor.UseVisualStyleBackColor = true;
            // 
            // lEntityId2
            // 
            this.lEntityId2.AutoSize = true;
            this.lEntityId2.Location = new System.Drawing.Point(6, 45);
            this.lEntityId2.Name = "lEntityId2";
            this.lEntityId2.Size = new System.Drawing.Size(42, 13);
            this.lEntityId2.TabIndex = 5;
            this.lEntityId2.Text = "EntityId";
            // 
            // tbEntityId2
            // 
            this.tbEntityId2.Location = new System.Drawing.Point(94, 45);
            this.tbEntityId2.Name = "tbEntityId2";
            this.tbEntityId2.Size = new System.Drawing.Size(64, 20);
            this.tbEntityId2.TabIndex = 4;
            // 
            // lPriority
            // 
            this.lPriority.AutoSize = true;
            this.lPriority.Location = new System.Drawing.Point(9, 151);
            this.lPriority.Name = "lPriority";
            this.lPriority.Size = new System.Drawing.Size(61, 13);
            this.lPriority.TabIndex = 21;
            this.lPriority.Text = "Приоритет";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.cbPriority.Location = new System.Drawing.Point(101, 148);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 21);
            this.cbPriority.TabIndex = 20;
            // 
            // cbTimeNotSet
            // 
            this.cbTimeNotSet.AutoSize = true;
            this.cbTimeNotSet.Location = new System.Drawing.Point(314, 124);
            this.cbTimeNotSet.Name = "cbTimeNotSet";
            this.cbTimeNotSet.Size = new System.Drawing.Size(143, 17);
            this.cbTimeNotSet.TabIndex = 19;
            this.cbTimeNotSet.Text = "Уточнить время позже";
            this.cbTimeNotSet.UseVisualStyleBackColor = true;
            // 
            // lPlace
            // 
            this.lPlace.AutoSize = true;
            this.lPlace.Location = new System.Drawing.Point(6, 124);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(39, 13);
            this.lPlace.TabIndex = 18;
            this.lPlace.Text = "Место";
            // 
            // tPlace
            // 
            this.tPlace.Location = new System.Drawing.Point(101, 121);
            this.tPlace.Name = "tPlace";
            this.tPlace.Size = new System.Drawing.Size(207, 20);
            this.tPlace.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата окончания";
            // 
            // dEndDate
            // 
            this.dEndDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dEndDate.Location = new System.Drawing.Point(101, 95);
            this.dEndDate.Name = "dEndDate";
            this.dEndDate.Size = new System.Drawing.Size(200, 20);
            this.dEndDate.TabIndex = 15;
            // 
            // dStartDate
            // 
            this.dStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dStartDate.Location = new System.Drawing.Point(101, 69);
            this.dStartDate.Name = "dStartDate";
            this.dStartDate.Size = new System.Drawing.Size(200, 20);
            this.dStartDate.TabIndex = 14;
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Location = new System.Drawing.Point(6, 75);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(71, 13);
            this.lStartDate.TabIndex = 13;
            this.lStartDate.Text = "Дата начала";
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = true;
            this.lTheme.Location = new System.Drawing.Point(6, 45);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(34, 13);
            this.lTheme.TabIndex = 12;
            this.lTheme.Text = "Тема";
            // 
            // tTheme
            // 
            this.tTheme.Location = new System.Drawing.Point(101, 42);
            this.tTheme.Name = "tTheme";
            this.tTheme.Size = new System.Drawing.Size(207, 20);
            this.tTheme.TabIndex = 11;
            // 
            // bCreateEntity
            // 
            this.bCreateEntity.Location = new System.Drawing.Point(103, 253);
            this.bCreateEntity.Name = "bCreateEntity";
            this.bCreateEntity.Size = new System.Drawing.Size(167, 23);
            this.bCreateEntity.TabIndex = 10;
            this.bCreateEntity.Text = "Создать объект";
            this.bCreateEntity.UseVisualStyleBackColor = true;
            this.bCreateEntity.Click += new System.EventHandler(this.bCreateEntity_Click);
            // 
            // rCall
            // 
            this.rCall.AutoSize = true;
            this.rCall.Location = new System.Drawing.Point(232, 19);
            this.rCall.Name = "rCall";
            this.rCall.Size = new System.Drawing.Size(62, 17);
            this.rCall.TabIndex = 9;
            this.rCall.Text = "Звонок";
            this.rCall.UseVisualStyleBackColor = true;
            // 
            // rMeeting
            // 
            this.rMeeting.AutoSize = true;
            this.rMeeting.Location = new System.Drawing.Point(117, 19);
            this.rMeeting.Name = "rMeeting";
            this.rMeeting.Size = new System.Drawing.Size(66, 17);
            this.rMeeting.TabIndex = 8;
            this.rMeeting.Text = "Встреча";
            this.rMeeting.UseVisualStyleBackColor = true;
            // 
            // rMail
            // 
            this.rMail.AutoSize = true;
            this.rMail.Checked = true;
            this.rMail.Location = new System.Drawing.Point(7, 19);
            this.rMail.Name = "rMail";
            this.rMail.Size = new System.Drawing.Size(65, 17);
            this.rMail.TabIndex = 7;
            this.rMail.TabStop = true;
            this.rMail.Text = "Письмо";
            this.rMail.UseVisualStyleBackColor = true;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(101, 349);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(167, 23);
            this.bLoad.TabIndex = 3;
            this.bLoad.Text = "Загрузить объект";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // tbEntityId
            // 
            this.tbEntityId.Location = new System.Drawing.Point(101, 323);
            this.tbEntityId.Name = "tbEntityId";
            this.tbEntityId.Size = new System.Drawing.Size(66, 20);
            this.tbEntityId.TabIndex = 0;
            // 
            // lEntityId
            // 
            this.lEntityId.AutoSize = true;
            this.lEntityId.Location = new System.Drawing.Point(6, 326);
            this.lEntityId.Name = "lEntityId";
            this.lEntityId.Size = new System.Drawing.Size(42, 13);
            this.lEntityId.TabIndex = 1;
            this.lEntityId.Text = "EntityId";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WebApiExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 644);
            this.Controls.Add(this.tcApi);
            this.Controls.Add(this.gbAuthorization);
            this.Controls.Add(this.debugView);
            this.Controls.Add(this.gbMainInfo);
            this.Name = "WebApiExampleForm";
            this.gbMainInfo.ResumeLayout(false);
            this.gbMainInfo.PerformLayout();
            this.gbAuthorization.ResumeLayout(false);
            this.gbAuthorization.PerformLayout();
            this.tcApi.ResumeLayout(false);
            this.tpStartProcess.ResumeLayout(false);
            this.gbStartProcess.ResumeLayout(false);
            this.gbStartProcess.PerformLayout();
            this.tpTree.ResumeLayout(false);
            this.gbTree.ResumeLayout(false);
            this.gbTree.PerformLayout();
            this.gbWhom.ResumeLayout(false);
            this.gbWhom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox urlServer;
        private System.Windows.Forms.Label urlServerLabel;
        private System.Windows.Forms.GroupBox gbMainInfo;
        private System.Windows.Forms.Button checkServer;
        private System.Windows.Forms.RichTextBox debugView;
        private System.Windows.Forms.GroupBox gbAuthorization;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TabControl tcApi;
        private System.Windows.Forms.TabPage tpStartProcess;
        private System.Windows.Forms.GroupBox gbStartProcess;
        private System.Windows.Forms.Label lProcessName;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.Button bStartProcess;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label lToken;
        private System.Windows.Forms.Button bChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tpTree;
        private System.Windows.Forms.GroupBox gbTree;
        private System.Windows.Forms.RadioButton rCall;
        private System.Windows.Forms.RadioButton rMeeting;
        private System.Windows.Forms.RadioButton rMail;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TextBox tbEntityId;
        private System.Windows.Forms.Label lEntityId;
        private System.Windows.Forms.Button bCreateEntity;
        private System.Windows.Forms.Label lTheme;
        private System.Windows.Forms.TextBox tTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dEndDate;
        private System.Windows.Forms.DateTimePicker dStartDate;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.TextBox tPlace;
        private System.Windows.Forms.CheckBox cbTimeNotSet;
        private System.Windows.Forms.Label lPriority;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.GroupBox gbWhom;
        private System.Windows.Forms.RadioButton rLead;
        private System.Windows.Forms.RadioButton rContact;
        private System.Windows.Forms.RadioButton rContractor;
        private System.Windows.Forms.Label lEntityId2;
        private System.Windows.Forms.TextBox tbEntityId2;
    }
}

