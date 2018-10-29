using Timesheet.Entities.Models;
using Timesheet.Service.DTO;
using Timesheet.Service.Interfaces;

namespace Timesheet.Service
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository empRepo;
		private readonly EmployeeSchadule employeeSchadule;

		public EmployeeService(IEmployeeRepository employeeRepo)
		{
			this.empRepo = employeeRepo;
		}

		public EmployeeDto FindEmployee(string userName, string password)
		{
			var empl = empRepo.FindByUserName(userName, password);
			return empl;
		}
	}
}
