using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uploads_api.Context;
using uploads_api.DTOs;

namespace uploads_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly PKContext _context;
        private readonly IWebHostEnvironment _env;

        public ImageController(PKContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImageDTO>> GetImageById(Guid id)
        {
            var image = await _context.ImageModel
                .Where(i => i.Id == id)
                .Select(i => new ImageDTO
                {
                    Id = i.Id.ToString(),
                    URL = i.Url,
                    ImageData = i.ImageData,
                    AltText = i.AltText,
                    UploadedAt = i.UploadedAt.ToString("o")
                })
                .FirstOrDefaultAsync();

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
   
        }
    }
}