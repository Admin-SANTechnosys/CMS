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

        public ActionResult GetUserDetails()
        {
            var model = new List<UserModel>();
            try
            {
                using (var context = new CMSContext())
                {
                    var value = context.Users.ToList();
                    foreach (var user in value)
                    {
                        var UserModel = new UserModel();
                        UserModel.Username = user.Username;
                        UserModel.Password = user.Password;
                        model.Add(UserModel);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return PartialView("_UserDetailView", model);
        }
        public ActionResult SaveUserDetail()
        {
            try
            {
                for (int counter = 0; counter < 5; counter++)
                {
                    var User = new User()
                    {
                        Username = "Username " + counter,
                        Password = "Mindfire Solutions " + counter,
                        Fname = "Software Engineer",
                        Lname = "Lname"
                    };
                    using (var context = new CMSContext())
                    {
                        context.Users.Add(User);
                        context.SaveChanges();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Json(true);
        }

    }
}
