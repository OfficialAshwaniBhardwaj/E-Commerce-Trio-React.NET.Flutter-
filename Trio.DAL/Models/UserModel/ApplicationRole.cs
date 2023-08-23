﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trio.DAL.Models.UserModel
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole>? UserRoles { get; set; }

    }
}
