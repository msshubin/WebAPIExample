using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public enum RelationshipCallType
    {
        /// <summary>
        /// Входящий
        /// </summary>
        Input = 0,
        
        /// <summary>
        /// Исходящий
        /// </summary>
        Output = 1,
    }
}
