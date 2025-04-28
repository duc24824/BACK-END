using System.Diagnostics;
using Lap3.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lap3.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User() {id="1",username="aaa",password="1",Phone="111",email="111"},
            new User() {id="1",username="aaa",password="1",Phone="111",email="111"},
            new User() {id="1",username="aaa",password="1",Phone="111",email="111"},
            new User() {id="1",username="aaa",password="1",Phone="111",email="111"},
            new User() {id="1",username="aaa",password="1",Phone="111",email="111"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
    }
}