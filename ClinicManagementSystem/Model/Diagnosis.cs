using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Model
{
    class Diagnosis
    {
        public Appointment Appointment { get; set; }

        public string InitialDiagnosis { get; set; }

        public string FinalDiagnosis { get; set; }

    }
}
