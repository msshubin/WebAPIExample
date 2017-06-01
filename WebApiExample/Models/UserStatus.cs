using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiExample.Models
{
    public enum UserStatus
    {
        Active = 0,

        Blocked = 1,

        NotConfirmed = 10,

        System = 100,
    }
}
