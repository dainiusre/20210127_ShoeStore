using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database.Products
{
    public class Batas
    {
        [Key]
        public int BatasId { get; set; }
        public string BatoPavadinimas { get; set; }
        public string BatoTipas { get; set; }
        public decimal PorosKaina { get; set; }
    }
}
