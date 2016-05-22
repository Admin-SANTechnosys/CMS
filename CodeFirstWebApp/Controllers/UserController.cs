using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CMS.DATAACCESS;
using CMS.ENTITY;
using CMSPLATFORM.Models;

namespace CMSPLATFORM.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

    }
}
