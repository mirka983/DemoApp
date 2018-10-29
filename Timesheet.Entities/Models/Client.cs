namespace Timesheet.Entities.Models
{
	public class Client : BaseEntity
	{
		public string ClientName { get; set; }

		public int ActivityId { get; set; }
	}
}
