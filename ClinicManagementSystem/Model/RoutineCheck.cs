using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class RoutineCheck
	{
		public Appointment Appointment { get; set; }
		public Nurse Nurse { get; set; } = new Nurse();
		public int BloodPressureSystolic { get; set; }
		public int BloodPressureDiastolic { get; set; }
		public double BodyTemp { get; set; }
		public int Pulse { get; set; }
		public double Weight { get; set; }
		public string Symptoms { get; set; }
		public bool IsFinished => !string.IsNullOrEmpty(this.Nurse.ID);
	}
}
