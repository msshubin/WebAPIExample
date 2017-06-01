using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Guid Uid { get; set; }
    }
}
