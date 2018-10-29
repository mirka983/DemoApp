using System;
using Timesheet.Core.Interfaces;
using Timesheet.Entities.Models;

namespace Timesheet.Infrastructure
{
	public class JobRepository : IJobRepository
	{
		Job IJobRepository.FindByCode(string code)
		{
			throw new NotImplementedException();
		}
	}
}
