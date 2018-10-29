using System;

namespace Timesheet.Presentation.Interfaces
{
	public interface ILoginView
	{
		void DisplayLogin();

		event Action<string, string> OnValidateUser;

		void ShowTimesheet(bool enabled);

		void DisplayError();
	}
}