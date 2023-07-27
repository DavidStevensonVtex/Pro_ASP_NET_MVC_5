using System;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
	public class HomeController : Controller
    {
        public ViewResult MakeBooking()
		{
            return View(new Appointment { Date = DateTime.Now });
		}

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
		{
            // statements to store new Appointment in a
            // repository would go here in a real project

            if (string.IsNullOrEmpty(appt.ClientName))
			{
                ModelState.AddModelError("ClientName", "Please enter your name");
			}

            if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
			{
                ModelState.AddModelError("Date", "Please enter a date in the future.");
			}

            if (! appt.TermsAccepted)
			{
                ModelState.AddModelError("TermsAccepted", "You must accept the terms");
			}

            if (ModelState.IsValid)
			{
                return View("Completed", appt);
            }
            else
			{
                return View();
			}
        }
    }
}