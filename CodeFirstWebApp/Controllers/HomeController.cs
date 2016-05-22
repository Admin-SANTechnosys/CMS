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


    }
}
