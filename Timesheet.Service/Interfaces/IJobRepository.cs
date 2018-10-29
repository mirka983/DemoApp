using Timesheet.Entities.Models;

namespace Timesheet.Core.Interfaces
{
	public interface IJobRepository
	{
		Job FindByCode(string code);
	}
}
