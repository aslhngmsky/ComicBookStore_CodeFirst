using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cizgiromandukkani.Entities
{
   public class kategori
    {
        public int kategoriID { get; set; }
        public string kategoriadi { get; set; }
        public virtual ICollection<urun> urun { get; set; }//bir kategoride birden fazla ürün yer alabilir
    }
}
