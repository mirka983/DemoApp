using Timesheet.Entities.Models;
using Timesheet.Service.DTO;

namespace Timesheet.Service.Interfaces
{
	public interface IEmployeeRepository
	{
		Employee FindById(int id);
		EmployeeDto FindByUserName(string userName, string password);
		Employee FindByCode(string code);
		Employee FindEmpManager(string empManager);
	}
}
