using System;
using System.Windows.Forms;
using Timesheet.Presentation.Interfaces;

namespace Timesheet.Presentation
{
	public partial class LoginForm : Form, ILoginView
	{
		public event Action<string, string> OnValidateUser;

		public LoginForm()
		{
			this.InitializeComponent();
			this.txtBoxPassword.PasswordChar = '*';
		}

		public void ShowTimesheet(bool enabled)
		{
			Close();
			var ts = new Timesheet(enabled);
			ts.Show();
		}

		public void DisplayError()
		{
			this.lblMessage.Text = "Invalid username or password";
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		public void buttonLogin_Click(object sender, EventArgs e)
		{
			if (this.OnValidateUser != null)
			{
				this.OnValidateUser(this.txtBoxUserName.Text, this.txtBoxPassword.Text);
			}
		}

		public void DisplayLogin()
		{
			ShowDialog();
		}
	}
}


