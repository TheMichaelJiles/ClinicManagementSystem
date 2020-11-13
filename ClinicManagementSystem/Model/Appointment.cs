using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class Appointment
	{

		public DateTime Date { get; set; }
		public int PatientID { get; set; }
		public Doctor Doctor { get; set; } = new Doctor();
		public int ID { get; set; }
		public string Reasons { get; set; }
		public bool IsPastDate => this.Date <= DateTime.Now;

    }
}
