using System;
using System.Windows.Forms;
using Timesheet.Core.DTO;
using Timesheet.Core.Interfaces;
using Timesheet.Infrastructure;

namespace Timesheet.Presentation
{
	public partial class Timesheet : Form
	{
		public readonly EmployeeDto employeeDto;
		public readonly EmployeeRepository employeeRepository;
		public Timesheet(bool enabled)
		{
			this.InitializeComponent();
			Enabled = enabled;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			var time = this.statusBar1.Panels[0].Text;
			time = this.employeeDto.HasShift().Value.ToLongTimeString();
			Show();
		}

	}
}
