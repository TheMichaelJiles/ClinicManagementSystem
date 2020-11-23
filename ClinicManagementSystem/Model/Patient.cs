using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
    /// <summary>
    /// The patient dataclass
    /// </summary>
    public class Patient
	{

        #region Properties

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>Gets or sets the bio.</summary>
        /// <value>The bio.</value>
        public Bio Bio { get; set; } = new Bio();

		#endregion
	}
}
