using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class Replacement
    {
        public Guid Uid {get; set;}

        /// <summary>
        /// Замещаемый
        /// </summary>
        /// <remarks>
        /// Замещаемый пользователь
        /// </remarks>
        public User SourceUser
        {
            get;
            set;
        }

        /// <summary>
        /// Замещающий
        /// </summary>
        /// <remarks>
        /// Замещающий пользователь
        /// </remarks>
        public User TargetUser
        {
            get;
            set;
        }

        /// <summary>
        /// Дата начала
        /// </summary>
        /// <remarks>
        /// Дата начала замещения
        /// </remarks>
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Дублировать сообщения
        /// </summary>
        /// <remarks>
        /// Дублировать или нет сообщения Замещаемому, если "Да" - сообщения уходят Замещаемому и Замещающему.
        /// </remarks>
        public Nullable<bool> DuplicateMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Предварительное замещение
        /// </summary>
        /// <remarks>
        /// Количество рабочих дней, за которое требуется выполнять механизм замещения (переназначение задач, информирование пользователей и т.п.) до фактической даты начала замещения
        /// </remarks>
        public long PreReplace
        {
            get;
            set;
        }

        /// <summary>
        /// Статус
        /// </summary>
        /// <remarks>
        /// Статус замещения, служебное свойство
        /// </remarks>
        public ReplacementStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Дата завершения
        /// </summary>
        /// <remarks>
        /// Дата завершения замещения
        /// </remarks>
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// IsDeleted
        /// </summary>
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// HardDelete
        /// </summary>
        public bool HardDelete
        {
            get;
            set;
        }
    }
}
