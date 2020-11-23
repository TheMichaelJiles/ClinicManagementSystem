using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Model
{
    /// <summary>
    /// The diagnosis dataclass
    /// </summary>
    public class Diagnosis
    {
        /// <summary>Gets or sets the appointment identifier.</summary>
        /// <value>The appointment identifier.</value>
        public int AppointmentID { get; set; }

        /// <summary>Gets or sets the initial diagnosis.</summary>
        /// <value>The initial diagnosis.</value>
        public string InitialDiagnosis { get; set; }

        /// <summary>Gets or sets the final diagnosis.</summary>
        /// <value>The final diagnosis.</value>
        public string FinalDiagnosis { get; set; }
    }
}
