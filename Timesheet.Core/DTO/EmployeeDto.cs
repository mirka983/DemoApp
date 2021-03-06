﻿using System;
using Timesheet.Entities.Models;

namespace Timesheet.Service.DTO
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
	}
}
