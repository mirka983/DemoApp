using Timesheet.Core.DTO;
using Timesheet.Core.Interfaces;
using Timesheet.Entities.Models;

namespace Timesheet.Core
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository empRepo;
		private readonly EmployeeDto employeeDto;

		public EmployeeService(IEmployeeRepository employeeRepo)
		{
			this.empRepo = employeeRepo;
		}

		public EmployeeDto FindEmployee(string userName, string password)
		{
			var empl = this.empRepo.FindByUserName(userName, password);
			return empl;
		}
	}
}
