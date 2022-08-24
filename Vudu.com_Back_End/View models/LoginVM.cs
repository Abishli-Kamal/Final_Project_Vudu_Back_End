﻿using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.View_models
{
    public class LoginVM
    {
        [Required, StringLength(maximumLength: 20)]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
