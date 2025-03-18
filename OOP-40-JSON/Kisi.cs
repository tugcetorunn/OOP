using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_40_JSON
{
    internal class Kisi
    {
        public int page { get; set; } // JsonProperty("page") ile de eşleştirebiliriz 
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Data> data { get; set; } // büyük harfi de kabul eder
    }
}
