using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsume.Models
{
    public class Cases
    {
        public string Country { get; set; }
        public int active { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }
        public string updated_at { get; set; }
    }
}