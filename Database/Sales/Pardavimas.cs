using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database.Sales
{
    public class Pardavimas
    {
        [Key]
        public int PardavimasId { get; set; }
        public int BatasId { get; set; }
        public string ParduotaPoru { get; set; }
        public double GautaPinigu { get; set; }
    }
}
