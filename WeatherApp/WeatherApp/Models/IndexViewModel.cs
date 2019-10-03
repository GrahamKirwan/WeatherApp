using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class IndexViewModel
    {
        public string NameOfHome { get; set; }

        public IndexViewModel(string nameOfHome)
        {
            NameOfHome = nameOfHome;
        }
    }
}
