using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cizgiromandukkani.Entities
{
   public class musteri
    {
       [Key]
       public int musteriID { get; set; }

       public string musteriAdi { get; set; }
       public string musteriSoyadi { get; set; }

    }
}
