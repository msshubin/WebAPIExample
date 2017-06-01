using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public enum ReplacementMode
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Ручное замещение
        /// </summary>
        ManualReplacement = 1,

        /// <summary>
        /// Автоматическое замещение
        /// </summary>
        AutoReplacement = 2,
    }
}
