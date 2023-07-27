using System;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Infrastructure;

namespace ModelValidation.Models
{
	public class Appointment
	{
		[Required(ErrorMessage = "Please enter your name")]
		public string ClientName { get; set; }

		[FutureDate(ErrorMessage = "Please enter a date in the future")]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		[MustBeTrue(ErrorMessage = "You must accept the terms")]
		public bool TermsAccepted { get; set; }
	}
}