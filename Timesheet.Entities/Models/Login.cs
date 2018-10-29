namespace Timesheet.Entities.Models
{
	public class Login : BaseEntity
	{
		public string Username { get; set; }

		public string Password { get; set; }

		public int EmployeeId { get; set; }
	}
}
