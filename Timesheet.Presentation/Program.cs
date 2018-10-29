using System;
using Timesheet.Presentation.Presenter;

namespace Timesheet.Presentation
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			var loginPresenter = new LoginPresenter(new LoginForm());
			System.Windows.Forms.Application.Run();
		}
	}
}
