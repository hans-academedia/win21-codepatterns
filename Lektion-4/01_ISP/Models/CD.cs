using _01_ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ISP.Models
{
    internal class CD : ICD
    {
        public decimal Weight { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string BookPublisher { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Translators { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Edition { get; set; }
        public string Serie { get; set; }
        public List<string> Readers { get; set; }
    }
}
