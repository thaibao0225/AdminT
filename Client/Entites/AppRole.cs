using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Entites
{
    public class AppRole : IdentityRole
    {
        public string Description { set; get; }

        public bool isDelete { set; get; }

    }
}
