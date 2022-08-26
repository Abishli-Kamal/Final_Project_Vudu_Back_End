using System.Collections.Generic;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.View_Models
{
    public class AdminChartVM
    {
        public List<Movie> Movies { get; set; }
        public List<AppUser> AppUsers { get; set; }


    }
}
