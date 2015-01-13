﻿namespace ShopMaker.Membership
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface IUserAccount 
	{
		string EmailAddress { get;set; }

		string Password { get;set; }

		string FirstName { get;set; }

		string LastName { get;set; }

		DateTime LastLoginDateTime { get;set; }

		string MobileNumber { get;set; }

		int WrongPasswordAttempt { get;set; }

		DateTime LastWrongPasswordAttemptDateTime { get;set; }

		string IPAddress { get;set; }

		DateTime RegistrationDateTime { get;set; }

		AccountStatusOptions AccountStatus { get;set; }

		bool MatchPassword(string plainPassword);

	}
}
