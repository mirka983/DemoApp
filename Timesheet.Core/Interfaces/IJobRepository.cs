using Timesheet.Entities.Models;

namespace Timesheet.Service.Interfaces
{
	public interface IJobRepository
	{
		Job FindByCode(string code);
	}
}
