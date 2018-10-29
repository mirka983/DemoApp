namespace Timesheet.Entities.Models
{
	public  class Activity : BaseEntity
	{
		public string Name { get; set; }

		public int ClientId { get; set; }
	}
}
