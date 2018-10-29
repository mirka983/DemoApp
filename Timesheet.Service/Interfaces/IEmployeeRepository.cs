using Timesheet.Core.DTO;
using Timesheet.Entities.Models;

namespace Timesheet.Core.Interfaces
{
	public interface IEmployeeRepository
	{
		Employee FindById(int id);
		EmployeeDto FindByUserName(string userName, string password);
		Employee FindByCode(string code);
		Employee FindEmpManager(string empManager);
	}
}
