using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class WorkflowStartProcessModel
    {
        //public long ProcessHeaderId { get; set; }

        public string ProcessToken { get; set; }

        public string ProcessName { get; set; }

        public object Context { get; set; }
    }

    public class WorkflowStartProcessModelResult
    {
        public bool Result { get; set; }

        public string Status { get; set; }

        public string ExecutionToken { get; set; }

        public long NextTaskId { get; set; }

        public IEnumerable<CurrentOperation> CurrentOperations { get; set; }
    }
}
