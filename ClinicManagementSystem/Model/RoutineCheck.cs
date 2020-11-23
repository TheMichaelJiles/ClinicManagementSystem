using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
    /// <summary>
    /// The routinecheck dataclass
    /// </summary>
    public class RoutineCheck
	{
        /// <summary>Gets or sets the appointment.</summary>
        /// <value>The appointment.</value>
        public Appointment Appointment { get; set; }

        /// <summary>Gets or sets the nurse.</summary>
        /// <value>The nurse.</value>
        public Nurse Nurse { get; set; } = new Nurse();

        /// <summary>Gets or sets the blood pressure systolic.</summary>
        /// <value>The blood pressure systolic.</value>
        public int BloodPressureSystolic { get; set; }

        /// <summary>Gets or sets the blood pressure diastolic.</summary>
        /// <value>The blood pressure diastolic.</value>
        public int BloodPressureDiastolic { get; set; }

        /// <summary>Gets or sets the body temporary.</summary>
        /// <value>The body temporary.</value>
        public double BodyTemp { get; set; }

        /// <summary>Gets or sets the pulse.</summary>
        /// <value>The pulse.</value>
        public int Pulse { get; set; }

        /// <summary>Gets or sets the weight.</summary>
        /// <value>The weight.</value>
        public double Weight { get; set; }

        /// <summary>Gets or sets the symptoms.</summary>
        /// <value>The symptoms.</value>
        public string Symptoms { get; set; }

        /// <summary>Gets a value indicating whether this instance is finished.</summary>
        /// <value>
        ///   <c>true</c> if this instance is finished; otherwise, <c>false</c>.</value>
        public bool IsFinished => this.Nurse.ID > 0;
	}
}
