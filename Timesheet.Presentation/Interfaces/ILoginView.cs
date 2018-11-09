using System;
using Timesheet.Core.DTO;

namespace Timesheet.Presentation.Interfaces
{
	public interface ILoginView
	{
		void DisplayLogin();

		event Action<string, string> OnValidateUser;

		void ShowTimesheet(bool enabled, EmployeeDto emp);

		void DisplayError();
	}
}