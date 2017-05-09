using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using backend.Services.Methods;
using backend.Services.Models.Entities;
using backend.Services.Models;



namespace SocialMediaApp.Controllers
{
    public class RegisterController : Controller
    {
        UserService userService = new UserService();
        // GET: Register
      
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register reg)
        {
            userService.AddUser(reg);
            return View();
        }


    }
}