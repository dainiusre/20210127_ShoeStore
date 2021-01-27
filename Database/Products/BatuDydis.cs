using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database.Products
{
    public class BatuDydis
    {
        [Key]
        public int BatasId { get; set; }
        public int BatoDydis { get; set; }
        public int PoruKiekis { get; set; }
    }
}
