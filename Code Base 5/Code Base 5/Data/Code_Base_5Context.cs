using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Code_Base_5.Models;

namespace Code_Base_5.Data
{
    public class Code_Base_5Context : DbContext
    {
        public Code_Base_5Context (DbContextOptions<Code_Base_5Context> options)
            : base(options)
        {
        }

        public DbSet<Code_Base_5.Models.Student>? Student { get; set; }
    }
}
