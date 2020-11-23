using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
    /// <summary>The nurse dataclass</summary>
    public class Nurse
	{
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>Gets or sets the username.</summary>
        /// <value>The username.</value>
        public string Username { get; set; }

        /// <summary>Gets or sets the bio.</summary>
        /// <value>The bio.</value>
        public Bio Bio { get; set; } = new Bio();

        /// <summary>Gets or sets a value indicating whether this instance is admin.</summary>
        /// <value>
        ///   <c>true</c> if this instance is admin; otherwise, <c>false</c>.</value>
        public bool IsAdmin { get; set; }

        /// <summary>Gets or sets the address.</summary>
        /// <value>The address.</value>
        public Address Address { get; set; } = new Address();

	}
}
