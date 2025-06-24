using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploads_api.DTOs
{
    public class ImageDTO
    {
        public string Id { get; set; }
        public string URL { get; set; }
        public byte[] ImageData { get; set; }
        public string AltText { get; set; }
        public string UploadedAt { get; set; }
    }
}