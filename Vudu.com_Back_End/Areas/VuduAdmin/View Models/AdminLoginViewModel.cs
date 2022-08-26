using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Areas.VuduAdmin.View_Models
{
    public class AdminLoginViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 25, MinimumLength = 6),DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
