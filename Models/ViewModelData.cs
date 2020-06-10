using MvcTips.Models;
using APIConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class DataViewModel
    {
        public List<Tips> Tips { get; set; }
        public List<Cases> Data { get; set; }
    }
}