using System;
using Timesheet.Core.Interfaces;
using Timesheet.Entities.Models;

namespace Timesheet.Infrastructure
{
	public class ActivityRepository : IActivityRepository
	{
		public Activity FindByName(string name)
		{
			throw new NotImplementedException();
		}

		public Activity FindByClientCode(string clientCode)
		{
			throw new NotImplementedException();
		}
	}
}
