using Microsoft.AspNetCore.Mvc.Rendering;
using MvcTips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFill.ViewModels
{
    public class Fill
    {
        public List<Tips> Tips { get; set; }
        public SelectList Autors { get; set; }
        public string TipsAutor { get; set; }
        public string SearchString { get; set; }
    }
}