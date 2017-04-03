using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeEF.DAL;
using EmployeeEF.Models;

namespace EmployeeEF.Controllers
{
    public class LoginController : Controller
    {
        private AcmeContext db = new AcmeContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {

            if ((username == null) || (password == null))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Employee emp = null;
            try
            {
                emp = db.Employee.Single(e => (e.Username == username && e.Password == password));
            }
            catch (Exception e)
            {
                ViewBag.Message = "Username or password not found";
            }
            /*            var emp = from s in db.Employee
                                  where s.Username == username
                                  select s;
             */

            if (emp != null)
                return RedirectToAction("Details", "Employees", new { id = emp.ID });
            else
                return View();
 

        }

  
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
