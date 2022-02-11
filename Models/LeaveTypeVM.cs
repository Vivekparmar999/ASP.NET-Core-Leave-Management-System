using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }
        [Required]
        [Display(Name="Leave Type Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
