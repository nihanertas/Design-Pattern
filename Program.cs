using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtDunyasi
{
    class Program
    {
        static void Main(string[] args)
        {
            TavukEti TavukEti = new TavukEti();
            TavukEti.tarif();

            KirmiziEt KirmiziEt = new KirmiziEt();
            KirmiziEt.tarif();

            ITavukSosu etAdaptor = new KirmiziEtAdaptor(TavukEti);
            etAdaptor.kekik();
            etAdaptor.krema();

        }
    }
}
