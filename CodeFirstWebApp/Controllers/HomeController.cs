using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DATAACCESS;
using CMS.ENTITY;
using CMSPLATFORM.Models;

namespace CMSPLATFORM.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /// <summary>
        /// Start method which will insert multiple records and return values to view
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            try
            {
                //implementation of IDatabaseInitializer that will delete, recreate,
                //and optionally re-seed the database with data only if the model has changed since the database was created. 
                //This implementation require you to use the type of the Database Context because it’s a generic class. 
           //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CMSContext>());
                return View();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        /// <summary>
        /// Get employee details
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// populate some hardcoded value in employee table
        /// </summary>
        public ActionResult InsertUserDetail()
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
