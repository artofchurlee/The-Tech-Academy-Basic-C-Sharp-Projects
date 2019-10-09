using Insurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    int carYear, string carMake, string carModel, int speedingTickets, 
                                    bool driveIntoxicated = false, bool fullCoverage = false)
        {


            decimal ageFee = GetFeesForAge(dateOfBirth);
            decimal carFee = CarFee(carYear, carMake, carModel);
            decimal tixFee = SpeedTix(speedingTickets);
            decimal subtotalFee = ageFee + carFee + tixFee;

            decimal extraFeeDUI = 0;
            decimal extraFeeFC = 0;


            if (driveIntoxicated == true)
            {
                extraFeeDUI = subtotalFee * (decimal).25;
            }

            if (fullCoverage == true)
            {
                extraFeeFC = subtotalFee * (decimal).5;
            }
            decimal insQuote = extraFeeDUI + extraFeeFC + subtotalFee;


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
                customer.SpeedingTickets = speedingTickets;
                customer.DriveIntoxicated = driveIntoxicated;
                customer.FullCoverage = fullCoverage;
                customer.InsQuote = Convert.ToDecimal(insQuote);

                db.CustomerInfoes.Add(customer);
                db.SaveChanges();
            }
            ViewBag.insQuote = insQuote;
            ViewBag.firstName = firstName;
            ViewBag.lastName = lastName;

            return View("Quote");

        }

        private decimal GetFeesForAge(DateTime dateOfBirth)
        {
            //base price is 50/mo
            decimal ageFee = 50;

            //if user is under 25, add 25/mo
            decimal now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            decimal dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
            decimal age = (now - dob) / 10000;

            if (age < 25 && age >= 18)
            {
                ageFee += 25;
            }
            else if (age < 18) //if user is under 18, add 100/mo
            {
                ageFee += 100;
            }
            else if (age > 100) //if user is over 100, add 25/mo
            {
                ageFee += 25;
            }

            return ageFee;
        }

        private decimal CarFee(int carYear, string carMake, string carModel)
        {
            decimal carFee = 0;
            if (carYear < 2000 || carYear > 2015)
            {
                carFee += 25;
            }

            if (carMake.ToLower() == "porsche")
            {
                carFee += 25;
            }

            if (carModel.ToLower() == "911 carrera")
            {
                carFee += 25;
            }

            return carFee;
        }

        private decimal SpeedTix(int speedingTicket)
        {
            if (speedingTicket != 0)
            {
                decimal tixFee = speedingTicket * 10;
                return tixFee;
            }
            else return 0;

        }

    }
}