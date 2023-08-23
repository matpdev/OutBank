using System;
namespace OutBank
{
	public class User
	{
		String name = "";
		String email = "";
		String password = "";
        DateTime birthDate = DateTime.Now;

		public User(String nameData, String emailData, String passwordData, DateTime BirthDateData)
		{
			name = nameData;
			email = emailData;
			password = passwordData;
			birthDate = BirthDateData;
		}
	}
}