using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTips.Models
{
    public class Tips
    {
        public int Id { get; set; }
        public string UrlImg { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }
        public string References { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}