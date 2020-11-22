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
		public Patient Patient { get; set; } = new Patient();
		public Doctor Doctor { get; set; } = new Doctor();
		public Diagnosis Diagnosis { get; set; } = new Diagnosis();
		public RoutineCheck RoutineCheck { get; set; } = new RoutineCheck();
		public int ID { get; set; }
		public string Reasons { get; set; }
		public bool IsEditable => !IsPastDate && string.IsNullOrEmpty(Diagnosis.InitialDiagnosis) && string.IsNullOrEmpty(Diagnosis.FinalDiagnosis);
		public bool IsPastDate => this.Date <= DateTime.Now;
		public bool IsFinalized => !string.IsNullOrEmpty(this.Diagnosis.FinalDiagnosis);

    }
}
