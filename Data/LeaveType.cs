using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Data
{
    public class LeaveType:BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
