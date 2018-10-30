using System;
using Timesheet.Core.DTO;
using Timesheet.Core.Interfaces;
using Timesheet.Entities.Models;

namespace Timesheet.Infrastructure
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly DboConnection dbconnection;

		public EmployeeRepository()
		{
			this.dbconnection = new DboConnection();
		}

		public Employee FindById(int id)
		{
			throw new NotImplementedException();
		}

		public EmployeeDto FindByUserName(string username, string password)
		{
			var empSchadule = new EmployeeSchadule();
			var emp = new Employee();

			var query = string.Format("SELECT l.Id, e.FirstName,e.LastName, e.Email," +
									" e.Manager,e.EmpSchaduleId, es.ShiftStart, es.ShiftEnd," +
									"es.ShiftCreated FROM( dbo.Login l " +
									"INNER JOIN dbo.Employee e ON  l.Id = e.Id " +
									"INNER JOIN dbo.EmployeeSchadule es ON es.Id = e.Id) " +
									"WHERE l.Username = '{0}' AND l.Password = '{1}'", username, password);

			try
			{
				var tbl = this.dbconnection.ExecuteReader(query);
				if (tbl.Rows.Count == 0)
				{
					return null;
				}

				emp.FirstName = Convert.ToString(tbl.Rows[0]["FirstName"]);
				emp.LastName = Convert.ToString(tbl.Rows[0]["LastName"]);
				emp.EmpManager = Convert.ToString(tbl.Rows[0]["Manager"]);
				emp.Id = Convert.ToInt32(tbl.Rows[0]["Id"]);
				emp.EmpScheduleId = Convert.ToInt32(tbl.Rows[0]["EmpSchaduleId"]);
				empSchadule.ShiftCreated = (DateTime?)tbl.Rows[0]["ShiftCreated"];
				empSchadule.ShiftStart = (TimeSpan)tbl.Rows[0]["ShiftStart"];
				empSchadule.ShiftEnd = (TimeSpan)tbl.Rows[0]["ShiftEnd"];

				return new EmployeeDto(emp, empSchadule);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public Employee FindByCode(string code)
		{
			throw new NotImplementedException();
		}

		public Employee FindEmpManager(string empManager)
		{
			throw new NotImplementedException();
		}
	}
}
