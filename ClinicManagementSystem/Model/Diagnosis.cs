using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Model
{
    public class Diagnosis
    {
        public int AppointmentID { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
    }
}
