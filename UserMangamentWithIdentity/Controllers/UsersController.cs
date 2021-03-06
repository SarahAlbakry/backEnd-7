﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserMangamentWithIdentity.Models;
using UserMangamentWithIdentity.ViewModels;

namespace UserMangamentWithIdentity.Controllers
{
    [Authorize(Roles = "Admin")]

    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.Users.Select(user=>new UserViewModel() 
            { 
              ID=user.Id,
              FirstName=user.FirstName,
              LastName=user.LastName,
              UserName=user.UserName,
              Email=user.Email,
              Roles=_userManager.GetRolesAsync(user).Result,
            }).ToListAsync();
            return View(user);
        }
    }
}
