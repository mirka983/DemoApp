using System;

namespace Timesheet.Entities.Models
{
	public class EmployeeSchadule : BaseEntity
	{
		public TimeSpan ShiftStart { get; set; }

		public TimeSpan ShiftEnd { get; set; }
		public DateTime? ShiftCreated { get; set; }
	}
}
