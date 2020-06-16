using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtDunyasi
{
    //ADAPTER YAZILIM TASARIM DESENİ KULLANILDI.
    class KirmiziEtAdaptor : ITavukSosu
    {
        ITavukSosu etSosu;
        public KirmiziEtAdaptor(ITavukSosu etSosu)
        {
            this.etSosu = etSosu;
        }

        public void kekik()
        {
            Console.WriteLine("Kirmizi etler kekiklerle beraber pisirildi...");
        }

        public void krema()
        {
            Console.WriteLine("Kirmizi etler kremayla beraber soslandı...");
        }
    }
}
