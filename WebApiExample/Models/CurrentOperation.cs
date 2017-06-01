using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class CurrentOperation
    {
        public string QueueElementName { get; set; }

        public DateTime ExecutionStart { get; set; }

        public DateTime NextExecuteDate { get; set; }
    }
}
