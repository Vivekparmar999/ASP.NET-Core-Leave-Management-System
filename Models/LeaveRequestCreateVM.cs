using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM:IValidatableObject
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public SelectList LeaveTypes{ get; set; }
        [Required]
        public int? LeaveTypeId { get; set; }
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must be before End Date",new[] { nameof(StartDate),nameof(EndDate)});
            }

            if (RequestComments?.Length > 250) 
            {
                yield return new ValidationResult("Comments are too Long",new[] { nameof(RequestComments)});
            }
        }
    }
}
