using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Git.Controllers
{
    public class UserController : Controller
    {
        public ActionResult GetAll()
        {
            return View(); 
        }
    }
}