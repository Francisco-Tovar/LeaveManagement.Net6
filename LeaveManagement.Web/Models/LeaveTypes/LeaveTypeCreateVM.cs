using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4,150, ErrorMessage = "Minimumg Length is 4 Characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1,90)]
        [Display(Name="Number of Days")]
        public int DefaultDays { get; set; }
    }
}
