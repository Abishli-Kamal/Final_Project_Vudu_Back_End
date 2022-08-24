using System.Collections.Generic;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.View_models
{
    public class MovieFilterVM
    {
        public List<MovieSubOptionSubTitle> MovieSubOptionSubTitles { get; set; }
        public List<Year> Years { get; set; }
        public HomeVM HomeVM { get; set; }
    }
}
