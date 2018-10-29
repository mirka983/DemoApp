using System;
using System.Windows.Forms;

namespace Timesheet.Presentation
{
	public partial class Timesheet : Form
	{
		public Timesheet(bool enabled)
		{
			this.InitializeComponent();
			Enabled = enabled;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
