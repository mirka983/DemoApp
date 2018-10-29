using System;
using Timesheet.Presentation.Interfaces;

namespace Timesheet.Presentation.Models.Employee
{
	public class NoEmployee : IEmployee
	{
		private static readonly Lazy<NoEmployee> lazy =
			new Lazy<NoEmployee>(() => new NoEmployee());

		public static NoEmployee Instance { get { return lazy.Value; } }

		private NoEmployee()
		{
		}

		public void ShowForm(ILoginView view)
		{
			view.DisplayError();
		}
	}
}
