using Timesheet.Core;
using Timesheet.Infrastructure;
using Timesheet.Presentation.Interfaces;
using Timesheet.Presentation.Models.Employee;

namespace Timesheet.Presentation.Helpers
{
	internal static class Utility
	{
		private static readonly EmployeeService empService;

		static Utility()
		{
			empService = new EmployeeService(new EmployeeRepository());
		}

		public static IEmployee GetEmployee(string userName, string password)
		{
			var emp = empService.FindEmployee(userName, password);
			if (emp == null)
			{
				return NoEmployee.Instance;
			}

			return new EmployeeModel(emp);
		}
	}
}
