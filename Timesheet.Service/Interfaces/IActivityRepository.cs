using Timesheet.Entities.Models;

namespace Timesheet.Core.Interfaces
{
	public interface IActivityRepository
	{
		Activity FindByName(string name);
		Activity FindByClientCode(string clientCode);
	}
}
