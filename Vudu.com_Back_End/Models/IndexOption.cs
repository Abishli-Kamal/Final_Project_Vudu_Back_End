﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class IndexOption
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<MovieIndexOption> MovieIndexOptions { get; set; }
    }
}
