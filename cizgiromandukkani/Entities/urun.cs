using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cizgiromandukkani.Entities
{
    public class urun
    {
        [Key]
        public int urunID { get; set; }
       
        public string urunadi { get; set; }
        public decimal fiyat { get; set; }
        public int stok { get; set; }
        public int kategoriID { get; set; }
        public  kategori kategori { get; set; }//sadece bir ürün için geçerli
    }
}
