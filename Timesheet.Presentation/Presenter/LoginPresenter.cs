using Timesheet.Presentation.Helpers;
using Timesheet.Presentation.Interfaces;

namespace Timesheet.Presentation.Presenter
{
	internal class LoginPresenter
	{
		private readonly ILoginView view;

		public LoginPresenter(ILoginView view)
		{
			this.view = view;
			view.OnValidateUser += this.ValidateUserHandler;
			view.DisplayLogin();
		}

		private void ValidateUserHandler(string userName, string password)
		{
			var employee = Utility.GetEmployee(userName, password);
			employee.ShowForm(this.view);
		}
	}
}
