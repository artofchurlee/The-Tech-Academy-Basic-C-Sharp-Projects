using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    int carYear, string carMake, string carModel, bool driveIntoxicated, int speedingTicket, bool fullCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/ViewStartPage/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var customer = new CustomerInfo();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.DateOfBirth = dateOfBirth;
                    customer.CarYear = carYear;
                    customer.CarMake = carMake;
                    customer.CarModel = carModel;
                    customer.DriveIntoxicated = driveIntoxicated;
                    customer.SpeedingTicket = speedingTicket;
                    customer.FullCoverage = fullCoverage;

                    db.CustomerInfoes.Add(customer);
                    db.SaveChanges();

                    
                }
                return View("Quote");
            }
        }
    }
}