using System;
using Timesheet.Entities.Models;

namespace Timesheet.Core.DTO
{
	public class EmployeeDto
	{
		private readonly Employee emp;
		private readonly EmployeeSchadule employeeSchadule;

		public EmployeeDto(Employee employeeDto, EmployeeSchadule employeeSchadule)
		{
			this.emp = employeeDto;
			this.employeeSchadule = employeeSchadule;

		}

		public bool HasShiftForToday
		{
			get
			{
				if (!this.employeeSchadule.ShiftCreated.HasValue)
				{
					return false;
				}

				string currentDate = DateTime.Now.ToShortDateString();
				DateTime shiftCreatedValue = this.employeeSchadule.ShiftCreated.Value;
				return currentDate.Equals(shiftCreatedValue.ToShortDateString());
			}

		}


		public string ShiftStart()
		{
			TimeSpan ts = new TimeSpan();
			ts = this.employeeSchadule.ShiftStart;
			string shiftStart = ts.ToString(@"hh\:mm");
			return shiftStart;
		}
		public string ShiftEnd()
		{
			TimeSpan ts = new TimeSpan();
			ts = this.employeeSchadule.ShiftEnd;
			string shiftEnd =  ts.ToString(@"hh\:mm");
			return shiftEnd;
		}
	}
}

