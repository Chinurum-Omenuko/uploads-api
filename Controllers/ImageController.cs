using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using uploads_api.Context;
using uploads_api.DTOs;
using Azure.Storage.Blobs;

namespace uploads_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly PKContext _context;
        private readonly IWebHostEnvironment _env;

        private readonly Uri _blobUri;
        private readonly BlobContainerClient _containerClient;

        public ImageController(PKContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            _blobUri = new Uri("https://dihhstorage.blob.core.windows.net/sqldbledgerdigests?sp=racwdl&st=2025-06-24T17:45:57Z&se=2027-03-04T02:45:57Z&spr=https&sv=2024-11-04&sr=c&sig=1nKdrKdyB1PX%2F7V9oER0Fv%2BD9GuvfveDzs8iw3lBoq8%3D");
            _containerClient = new BlobContainerClient(_blobUri);
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<ImageDTO>> GetImageById(Guid id)
        // {
        //     var image = await _context.ImageModel
        //         .Where(i => i.Id == id)
        //         .Select(i => new ImageDTO
        //         {
        //             Id = i.Id.ToString(),
        //             URL = i.Url,
        //             ImageData = i.ImageData,
        //             AltText = i.AltText,
        //             UploadedAt = i.UploadedAt.ToString("o")
        //         })
        //         .FirstOrDefaultAsync();

        //     if (image == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(image);

        // }


        [HttpPost]
        public async Task<ActionResult<ImageDTO>> UploadImage()
        {
            
        }
    }
}