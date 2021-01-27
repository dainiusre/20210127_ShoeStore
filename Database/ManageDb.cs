using _20210127_ShoeStore.Database.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210127_ShoeStore.Database
{
    public class ManageDb
    {
        public static void PridetiBatus()
        {

            using (var context = new Context())
            {
                context.Batai.Add(new Batas { BatasIdSurisantis = 100000001, BatoPavadinimas = "Žygio batai neperšlampami", BatoTipas = "Vyriški batai", PorosKaina = 99.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 200000001, BatoPavadinimas = "Žygio batai neperšlampami", BatoTipas = "Moteriški batai", PorosKaina = 99.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 300000001, BatoPavadinimas = "Žygio batai neperšlampami", BatoTipas = "Vaikiški batai", PorosKaina = 99.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 100000002, BatoPavadinimas = "Žygio batai peršlampami", BatoTipas = "Vyriški batai", PorosKaina = 79.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 200000002, BatoPavadinimas = "Žygio batai peršlampami", BatoTipas = "Moteriški batai", PorosKaina = 79.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 300000002, BatoPavadinimas = "Žygio batai peršlampami", BatoTipas = "Vaikiški batai", PorosKaina = 79.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 100000003, BatoPavadinimas = "Sandalai", BatoTipas = "Vyriški batai", PorosKaina = 29.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 200000003, BatoPavadinimas = "Sandalai", BatoTipas = "Moteriški batai", PorosKaina = 29.99M });
                context.Batai.Add(new Batas { BatasIdSurisantis = 200000003, BatoPavadinimas = "Sandalai", BatoTipas = "Vaikiški batai", PorosKaina = 29.99M });



                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 43, PoruKiekis = 100 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 42, PoruKiekis = 50 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 41, PoruKiekis = 100 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 44, PoruKiekis = 200 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 45, PoruKiekis = 50 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 100000001, BatoDydis = 46, PoruKiekis = 10 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 200000001, BatoDydis = 39, PoruKiekis = 10 });
                context.BatuDydziai.Add(new BatuDydis { BatasIdSurisantis = 300000001, BatoDydis = 35, PoruKiekis = 10 });




                context.SaveChanges();
            }

        }
    }
}
