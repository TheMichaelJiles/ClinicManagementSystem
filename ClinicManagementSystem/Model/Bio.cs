using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Model
{
	/// <summary>
	/// The bio dataclass
	/// </summary>
	public class Bio 
	{
        #region Properties

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>Gets the full name.</summary>
        /// <value>The full name.</value>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>Gets or sets the dob.</summary>
        /// <value>The dob.</value>
        public DateTime DOB { get; set; }

        /// <summary>Gets or sets the phone number.</summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; set; }

        /// <summary>Gets or sets the address.</summary>
        /// <value>The address.</value>
        public Address Address { get; set; } = new Address();

        /// <summary>Gets or sets the gender.</summary>
        /// <value>The gender.</value>
        public string Gender { get; set; }

		#endregion
	}
}
