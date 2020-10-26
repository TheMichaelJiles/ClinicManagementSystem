using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class Bio 
	{
		#region Properties

		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; } 
		public string FullName => $"{FirstName} {LastName}";
		public DateTime DOB { get; set; }
		public string PhoneNumber { get; set; }
		public Address Address { get; set; } = new Address();
		public string Gender { get; set; }

		#endregion
	}
}
