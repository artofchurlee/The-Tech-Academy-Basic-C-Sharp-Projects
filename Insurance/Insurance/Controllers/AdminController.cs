using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance.Models;
using Insurance.ViewModels;

namespace Insurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Index()
        {
            
            
            using (InsuranceEntities db = new InsuranceEntities())
            { 
                var customers = db.CustomerInfoes.ToList(); //pulling database info to a new list
                var customersVms = new List<InsuranceVm>(); //instantiating list
                foreach(var customer in customers)  //looping through list to add customer info to list
                {
                    var customersVm = new InsuranceVm();
                    customersVm.FirstName = customer.FirstName;
                    customersVm.LastName = customer.LastName;
                    customersVm.EmailAddress = customer.EmailAddress;
                    customersVm.InsQuote = customer.InsQuote;
                    customersVms.Add(customersVm);
                }

                return View(customersVms);
            }

            
        }



    }
}