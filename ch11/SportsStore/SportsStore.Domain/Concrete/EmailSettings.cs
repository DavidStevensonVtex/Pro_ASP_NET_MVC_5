﻿namespace SportsStore.Domain.Concrete
{
	public class EmailSettings
	{
		public string MailToAddress = "orders@example.com";
		public string MailFromAddress = "sportsstore@example.com";
		public bool UseSsl = true;
		public string Username = "MySmtpUsername";
		public string Password = "MySmtpPassword";
		public string ServerName = "smtp.example.com";
		public int ServerPort = 587;
		public bool WriteAsFile = true;
		public string FileLocation = @"d:\sports_store_emails";
	}
}
