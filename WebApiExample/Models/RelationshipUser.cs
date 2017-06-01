using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class RelationshipUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Guid TypeUid { get; set; }
        public User User { get; set; }
        public RelationshipUserStatus Status { get; set; }
    }
}
