using _20210127_ShoeStore.Database.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database
{
    class ManageDb
    {
        public static void PridetiBatus()
        {

            using (var context = new Context())
            {
                context.Batai.Add(new Batas {  BatasId = 1, BatoPavadinimas = "Žygio batai neperšlampami", BatoTipas = "Vyriški batai", PorosKaina = 99.99M });
                context.SaveChanges();

                context.BatuDydziai.Add(new BatuDydis { BatasId = 1, BatoDydis = 43, PoruKiekis = 100 });
                context.SaveChanges();
            }

        }
    }
}
