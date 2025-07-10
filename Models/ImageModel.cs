using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploads_api.Models
{
    public class ImageModel
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string? Title { get; set; }
        public byte[] ImageData { get; set; }
        public string AltText { get; set; }
        public string ContentType { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}