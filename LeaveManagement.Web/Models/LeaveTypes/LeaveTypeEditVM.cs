using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {        
        [Required]
        [Length(4, 150, ErrorMessage = "Minimumg Length is 4 Characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90)]
        [Display(Name = "Number of Days")]
        public int DefaultDays { get; set; }
    }
}
