using Timesheet.Service.DTO;

namespace Timesheet.Service.Interfaces
{
	public interface IEmployeeService
	{
		EmployeeDto FindEmployee(string userName, string password);
	}
}
