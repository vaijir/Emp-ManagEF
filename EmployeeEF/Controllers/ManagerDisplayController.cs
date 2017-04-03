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
    public class ManagerDisplayController : Controller
    {
        private AcmeContext db = new AcmeContext();

        // GET: ManagerDisplay
        public ActionResult Index(string managerID)
        {
            if (managerID == null)
            {
                ViewBag.Info = false;
                return View();

            }

            int mId = Convert.ToInt32(managerID);

            var emp = from s in db.Employee
                      where s.ManagerEmplID == mId
                      select s;

            if (emp == null)
            {
                return HttpNotFound();
            }

            ViewBag.Info = true;

            return View(emp);
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
