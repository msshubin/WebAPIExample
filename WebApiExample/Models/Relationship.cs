using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class Relationship
    {
        public Relationship(){}

        public long Id { get; set; }	
        public Guid TypeUid { get; set; }
        public Guid Uid { get; set; }
        public string Theme { get; set; }
        public List<RelationshipUser> RelationshipUsers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Completed { get; set; }
        public DateTime CreationDate { get; set; }
        public User CreationAuthor { get; set; }
        public DateTime ChangeDate { get; set; }
        public User ChangeAuthor { get; set; }
        public string Description { get; set; }
        public RelationshipPriority Priority { get; set; }
        public Sale Sale { get; set; }
        public DateTime DoneDate { get; set; }
        public Contractor Contractor { get; set; }
        public Contact Contact { get; set; }
        public List<Comment> Comments { get; set; }
        public Lead Lead { get; set; }
        public List<Contact> ContractorsContacts { get; set; }
        public string RelationshipUsersHash { get; set; }
        public List<Schedule> Schedules { get; set; }
        public bool IsDeleted { get; set; }
        public bool HardDelete { get; set; }
        public bool ExpiredNotificationSent { get; set; }
        public List<RelationshipPersonPermission> Permission { get; set; }
        public bool InheritPermissions { get; set; }
        public bool IsPrivate { get; set; }
    }
}
