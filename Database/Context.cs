using _20210127_ShoeStore.Database.Products;
using _20210127_ShoeStore.Database.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database
{
    public class Context: DbContext
    {
        public Context()
        { 
        }

        public DbSet<Batas> Batai { get; set; }
        public DbSet<BatuDydis> BatuDydziai { get; set; }
        public DbSet<Pardavimas> Pardavimas { get; set; }

    }
}
