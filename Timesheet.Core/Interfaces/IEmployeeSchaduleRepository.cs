using Timesheet.Entities.Models;
using Timesheet.Service.Interfaces;

namespace Timesheet.Service.Interfaces
{
	public interface IEmployeeSchaduleRepository
	{
		Employee ShiftStart(int start);
		Employee ShiftEnd(int end);
	}
}
