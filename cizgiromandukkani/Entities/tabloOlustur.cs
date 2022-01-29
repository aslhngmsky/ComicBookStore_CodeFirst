using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cizgiromandukkani.Entities
{
    class tabloOlustur :DbContext
    {
        public DbSet<urun> urun { get; set; }
        public DbSet<kategori> kategori { get; set; }
        public DbSet<musteri> musteri { get; set; }

    }
}
