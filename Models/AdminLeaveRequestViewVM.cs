using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveRequestViewVM
    {
        public AdminLeaveRequestViewVM(int totalRequests, int approvedRequests, int pendingRequests, int rejectedRequests, List<LeaveRequestVM> leaveRequests)
        {
            TotalRequests = totalRequests;
            ApprovedRequests = approvedRequests;
            PendingRequests = pendingRequests;
            RejectedRequests = rejectedRequests;
            LeaveRequests = leaveRequests;
        }
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }
        [Display(Name = "Äpproved Request")]
        public int ApprovedRequests { get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
