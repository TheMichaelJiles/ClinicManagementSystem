
namespace ClinicManagementSystem.Model
{
	/// <summary>
	/// The address dataclass
	/// </summary>
	public class Address
	{
		#region Properties
		/// <summary>
		/// Gets and sets the AddressID
		/// </summary>
		public int AddressID { get; set; }

		/// <summary>
		/// Gets and sets the Address1
		/// </summary>
		public string Address1 { get; set; }

		/// <summary>
		/// Gets and sets teh Address2
		/// </summary>
		public string Address2 { get; set; }

		/// <summary>
		/// Gest and sets the City
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Gets and sets the State
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Gest and sets the Zip
		/// </summary>
		public int Zip { get; set; }

		#endregion
	}
}