using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	public class Doctor
	{
		public string ID { get; set; }
		public Bio Bio { get; set; } = new Bio();
	}
}
