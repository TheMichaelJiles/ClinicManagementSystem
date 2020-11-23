using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	/// <summary>
	/// Appointment dataclass
	/// </summary>
	public class Appointment
	{

		/// <summary>
		/// Gets or sets the Date
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Gets and sets the Patient
		/// </summary>
		public Patient Patient { get; set; } = new Patient();

		/// <summary>
		/// Gets and sets the Doctor
		/// </summary>
		public Doctor Doctor { get; set; } = new Doctor();

		/// <summary>
		/// Gest and sets the Diagnosis
		/// </summary>
		public Diagnosis Diagnosis { get; set; } = new Diagnosis();

		/// <summary>
		/// Gets and sets the RoutineCheck
		/// </summary>
		public RoutineCheck RoutineCheck { get; set; } = new RoutineCheck();

		/// <summary>
		/// Gets and sets the ID
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Gets and sets the Reasons
		/// </summary>
		public string Reasons { get; set; }

		/// <summary>
		/// Checks whether or not the diagnosis is editable
		/// </summary>
		public bool IsEditable => !IsPastDate && string.IsNullOrEmpty(Diagnosis.InitialDiagnosis) && string.IsNullOrEmpty(Diagnosis.FinalDiagnosis);

		/// <summary>
		/// Checks if the date is in the past
		/// </summary>
		public bool IsPastDate => this.Date <= DateTime.Now;

		/// <summary>
		/// Checks if the diagnosis is finalized
		/// </summary>
		public bool IsFinalized => !string.IsNullOrEmpty(this.Diagnosis.FinalDiagnosis);

    }
}
