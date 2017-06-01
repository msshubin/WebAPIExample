using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class RelationshipMeeting : Relationship
    {
        public RelationshipMeeting(){}

        public string Place { get; set; }

        public bool TimeNotSet { get; set; }
    }
}
