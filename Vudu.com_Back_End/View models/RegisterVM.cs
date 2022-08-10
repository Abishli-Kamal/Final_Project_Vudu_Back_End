﻿using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.View_models
{
    public class RegisterVM
    {
        [Required, StringLength(maximumLength: 20)]
        public string Firstname { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string Username { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string Lastname { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool IHaveReadIAccept { get; set; }
    }
}
