using System.Collections.Generic;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.View_models
{
    public class HomeVM
    {
        public List<Setting> Settings { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<MainOption> MainOptions { get; set; }
        public List<SubOption> SubOptions { get; set; }
    }
}
