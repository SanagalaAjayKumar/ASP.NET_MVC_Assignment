using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MINI___PROJECT.Models;

namespace MINI___PROJECT.Data
{
    public class MINI___PROJECTContext : DbContext
    {
        public MINI___PROJECTContext (DbContextOptions<MINI___PROJECTContext> options)
            : base(options)
        {
        }

        public DbSet<MINI___PROJECT.Models.Products> Products { get; set; }
    }
}
