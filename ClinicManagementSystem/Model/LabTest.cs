using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
    /// <summary>
    /// The labtest dataclass
    /// </summary>
    public class LabTest
	{

        /// <summary>Gets or sets the appointment identifier.</summary>
        /// <value>The appointment identifier.</value>
        public int AppointmentID { get; set; }

        /// <summary>Gets or sets the type of the test.</summary>
        /// <value>The type of the test.</value>
        public TestType TestType { get; set; } = new TestType();

        /// <summary>Gets or sets the results.</summary>
        /// <value>The results.</value>
        public string Results { get; set; }

        /// <summary>Gets or sets the abnormality.</summary>
        /// <value>The abnormality.</value>
        public string Abnormality { get; set; }

        /// <summary>Gets or sets the date.</summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }

        /// <summary>Gets a value indicating whether this instance is finished.</summary>
        /// <value>
        ///   <c>true</c> if this instance is finished; otherwise, <c>false</c>.</value>
        public bool IsFinished => Date <= DateTime.Now && Date != default;//!string.IsNullOrEmpty(Results);
    }
}
