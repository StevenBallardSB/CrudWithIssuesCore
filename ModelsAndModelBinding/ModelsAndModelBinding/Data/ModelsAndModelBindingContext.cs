using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelsAndModelBinding;

namespace ModelsAndModelBinding.Models
{
    public class ModelsAndModelBindingContext : DbContext
    {
        public ModelsAndModelBindingContext (DbContextOptions<ModelsAndModelBindingContext> options)
            : base(options)
        {
        }

        public DbSet<ModelsAndModelBinding.Product> Product { get; set; }
    }
}
