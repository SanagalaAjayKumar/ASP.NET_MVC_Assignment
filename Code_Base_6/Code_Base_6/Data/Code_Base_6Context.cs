using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Code_Base_6.Models;

namespace Code_Base_6.Data
{
    public class Code_Base_6Context : DbContext
    {
        public Code_Base_6Context (DbContextOptions<Code_Base_6Context> options)
            : base(options)
        {
        }

        public DbSet<Code_Base_6.Models.Employe>? Employe { get; set; }
    }
}
