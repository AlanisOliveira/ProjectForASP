using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Core.Entities
{
    public enum ProjectStatusEnum
    {
        Created = 0,
        InProgress = 1,
        Suspended = 2,
        Cancelled = 3,
        Finished = 4
    }
}