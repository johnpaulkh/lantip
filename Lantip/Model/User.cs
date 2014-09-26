using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class User
	{
		public static string ADMINISTRATOR = "administartor";
		public static string OWNER = "owner";
		public static string EMPLOYEE = "employee";

		[DisplayName("Username")]
		public string username { get; set; }

		[DisplayName("Password")]
		public string password { get; set; }

		[DisplayName("Nama")]
		public string nama { get; set; }

		[DisplayName("Tipe User")]
		public string tipeUser { get; set; }

		public override string ToString()
		{
			return nama;
		}
	}
}
