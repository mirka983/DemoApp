using Timesheet.Core.DTO;

namespace Timesheet.Core.Interfaces
{
	public interface IEmployeeService
	{
		EmployeeDto FindEmployee(string userName, string password);
	}
}
