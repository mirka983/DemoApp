using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Timesheet.Infrastructure
{
	public class DboConnection
	{
		private readonly ConnectionStringSettings connectionString;

		public DboConnection()
		{
			this.connectionString = ConfigurationManager.ConnectionStrings["timesheetConnection"];
		}

		public DataTable ExecuteReader(string query)
		{
			var dataTable = new DataTable();
			using (var connection = new SqlConnection(this.connectionString.ConnectionString))
			{
				if (connection.State != ConnectionState.Open)
				{
					connection.Open();
				}

				using (SqlCommand com = new SqlCommand(query, connection))
				{
					using (var reader = com.ExecuteReader())
					{
						dataTable.Load(reader);
					}
				}
			}

			return dataTable;
		}
	}
}