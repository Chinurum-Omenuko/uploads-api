using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploads_api.DTOs
{
    public class UploadImageDTO
    {
        public IFormFile File { get; set; }
        public string? AltText { get; set; }
        public string? Title { get; set; }
    }
}