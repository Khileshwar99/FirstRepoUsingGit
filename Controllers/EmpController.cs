using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppUsingGit.Models;

namespace WebAppUsingGit.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> empList = new List<Emp>
            {
            new Emp{EId=1,EName="Atul",EDesig="Developer",EDOJ= new DateTime(day:12,month:12,year:2021)},
            new Emp{EId=2,EName="Raj",EDesig="Manager",EDOJ= new DateTime(day:11,month:12,year:2021)},
            };
            return View(empList);
        }
    }
}