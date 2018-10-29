using Timesheet.Entities.Models;

namespace Timesheet.Core.Interfaces
{
	public interface IEmployeeSchaduleRepository
	{
		Employee ShiftStart(int start);
		Employee ShiftEnd(int end);
	}
}
