using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class EntityQueryRequest
    {
        public Guid TypeUid { get; set; }

        public string EQLQuery { get; set; }

        public string Select { get; set; }

        //public string Sort { get; set; }

        //public int Limit { get; set; }

        //public int Offset { get; set; }

        //public Guid? FilterProviderUid { get; set; }

        //public string FilterProviderData { get; set; }
    }
}
