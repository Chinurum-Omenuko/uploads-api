using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploads_api.Models
{
    public class BlogModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}