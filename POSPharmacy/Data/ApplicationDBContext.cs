using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using POSPharmacy.Models;

namespace POSPharmacy.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        //public DbSet<CategoryModel> categories { get; set; }
    }
}
