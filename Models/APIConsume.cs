using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIConsume.Models
{
    public class Cases
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
        public string Date { get; set; }
    }
}