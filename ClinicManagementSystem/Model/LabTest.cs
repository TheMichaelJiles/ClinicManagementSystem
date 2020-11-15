using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class LabTest
	{

		public int AppointmentID { get; set; }
		public TestType TestType { get; set; } = new TestType();
		public string Results { get; set; }
		public string Abnormality { get; set; }
		public DateTime Date { get; set; }
		public bool IsFinished => Date <= DateTime.Now && Date != default;//!string.IsNullOrEmpty(Results);
    }
}
