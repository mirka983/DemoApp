using Timesheet.Core.DTO;
using Timesheet.Presentation.Interfaces;

namespace Timesheet.Presentation.Models.Employee
{
	internal class EmployeeModel : IEmployee
	{
		private readonly EmployeeDto emp;
		public EmployeeModel(EmployeeDto emp)
		{
			this.emp = emp;
		}

		public void ShowForm(ILoginView view)
		{
			view.ShowTimesheet(this.emp.HasShiftForToday,this.emp);
		}

	}
}
