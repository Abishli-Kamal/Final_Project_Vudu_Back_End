﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class Filter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Year> Years { get; set; }
        public List<Studio> Studios { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Tomatometer> Tomatometers { get; set; }
    }
}
