using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public class UserExt : User
    {
        public Guid TypeUid { get; set; }
        public Guid Uid { get; set; }
        public UserStatus Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmployDate { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public string Skype { get; set; }
        public string ICQ { get; set; }
        public string JabberID { get; set; }
        public Guid AuthProviderGuid { get; set; }
        public List<OrganizationItem> OrganizationItems { get; set; }
        public List<OrganizationItem> OrganizationGroups { get; set; }
        public User ReplacementUser { get; set; }
        public bool DuplicateMessage { get; set; }
        public DateTime EndReplacement { get; set; }
        public ReplacementMode ReplacementMode { get; set; }
        public Replacement Replacement { get; set; }
        public string OrganizationGroupsHash { get; set; }
        public string OrganizationItemsHash { get; set; }
        //Photo
        public string Lang { get; set; }
        public string EmailFormat { get; set; }
        public bool IsSystemLocal { get; set; }
        public WorkPlace WorkPlace { get; set; }
    }

    public class User
    {
        public long Id { get; set; }
    }
}
