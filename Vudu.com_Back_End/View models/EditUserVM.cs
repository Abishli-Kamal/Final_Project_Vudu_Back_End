using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.View_models
{
    public class EditUserVM
    {

        [Required, StringLength(maximumLength: 20)]
        public string Firstname { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string Username { get; set; }

        [Required, StringLength(maximumLength: 20)]
        public string Lastname { get; set; }
        [DataType(DataType.Password)]
        public string CurrenPassword { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string NewConfirmPassword { get; set; }
    }
}
