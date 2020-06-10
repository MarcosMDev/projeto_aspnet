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
        public Tips Tips { get; set; }
        public Cases Data { get; set; }
    }
}