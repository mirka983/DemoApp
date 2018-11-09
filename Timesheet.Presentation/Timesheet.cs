using System;
using System.Windows.Forms;
using Timesheet.Core.DTO;
using Timesheet.Infrastructure;

namespace Timesheet.Presentation
{
	public partial class Timesheet : Form
	{
		private readonly EmployeeDto employeeDto;
		public Timesheet(bool enabled, EmployeeDto emp)
		{
			this.employeeDto = emp;
			this.InitializeComponent();
			if (Enabled = enabled)
			{
				this.toolStripStatusLabel1.Text = "Open Timesheet";
				this.toolStripStatusLabel3.Text = string.Format("{0} - {1}", emp.ShiftStart(),
					emp.ShiftEnd());
			}
			else
			{
				this.toolStripStatusLabel1.Text = "Timesheet Closed";
				this.toolStripStatusLabel3.Text = string.Format("{0} - {1}", emp.ShiftStart(),
					emp.ShiftEnd());
			}

		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
