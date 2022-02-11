using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation: BaseEntity
    {

        //Foregin Key must be NavigationPropertyName+Id  or  [ForeginKey("LeaveTypeId")] in NavigationPropertyName
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
    }
}
