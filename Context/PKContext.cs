using Microsoft.EntityFrameworkCore;
using uploads_api.Models;

namespace uploads_api.Context
{
    public class PKContext : DbContext
    {
        public PKContext(DbContextOptions<PKContext> options) : base(options) { }

        // Ensure ImageModel exists in uploads_api.Models or replace with the correct model class
        public DbSet<ImageModel> ImageModel { get; set; }
    }
    
}

