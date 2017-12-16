using Microsoft.AspNetCore.Identity;
using PasswordVault.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordVault.Core.BLL.Services
{
    public interface IIdentityService
    {
        void Test();
    }

    public class IdentityService : IIdentityService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> loginManager;
        private readonly RoleManager<AppUserRole> roleManager;

        public IdentityService(UserManager<AppUser> userManager,
           SignInManager<AppUser> loginManager,
           RoleManager<AppUserRole> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }

        public void Test()
        {

        }
    }
}
