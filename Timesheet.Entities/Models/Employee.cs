namespace Timesheet.Entities.Models
{
	public class Employee : BaseEntity
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }
		public string EmpManager { get; set; }
		public int EmpScheduleId { get; set; }
	}
}