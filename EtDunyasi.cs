using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtDunyasi
{
    //TEMPLATE YAZILIM TASARIM DESENİ KULLANILDI.
    abstract class EtDunyasi : IEtDunyasi
    {
        public void tarif()
        {
            kesimSekli();
            pisirilme();
            sunum();
        }

        public abstract void kesimSekli();
        
        public void pisirilme()
        {
            Console.WriteLine("Etler lokum kıvamına gelene kadar pisirildi.");
        }

        public abstract void sunum();
       
    }
}
