using Timesheet.Entities.Models;

namespace Timesheet.Service.Interfaces
{
	public interface IActivityRepository
	{
		Activity FindByName(string name);
		Activity FindByClientCode(string clientCode);
	}
}
