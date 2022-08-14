using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grocery_Stroe_Online.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Grocery_Stroe_Online.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Login(User users)
        {
            if (ModelState.IsValid)
            {

                //return View("ShowLogin", users);
                return RedirectToAction("ShowLogin");

                
            }
            else
            {
                return View();

                //return View(users);
            }
        }
        [HttpGet]
        [ActionName("Login")]
        public IActionResult LoginGet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult ShowLogin()
        {
            return View();
        }

    }
}
