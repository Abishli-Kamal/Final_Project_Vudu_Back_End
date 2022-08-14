using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public bool IsBlock { get; set; }
    }
}
