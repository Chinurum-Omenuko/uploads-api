using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        // [HttpGet("{id}")]
        // public async Task<ActionResult<ImageDTO>> GetImage(Guid id)
        // {
        //     var image = await.context.Images.
        // }
    }
}