using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class Nurse
	{
		public string ID { get; set; }
		public string Username { get; set; }
		public Bio Bio { get; set; } = new Bio();
		public bool IsAdmin { get; set; }
		public Address Address { get; set; } = new Address();

	}
}
