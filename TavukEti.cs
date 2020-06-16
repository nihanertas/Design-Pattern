using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtDunyasi
{
    //TEMPLATE YAZILIM TASARIM DESENİ KULLANILDI.
    class TavukEti : EtDunyasi , ITavukSosu
    {
        public override void kesimSekli()
        {
            Console.WriteLine("Tavuk etleri uzun uzun kesildi...");
        }

        public override void sunum()
        {
            Console.WriteLine("Tavuk etleri mantarla servis edildi...");
        }

        public void kekik()
        {
            Console.WriteLine("Tavuk etleri kekiklerle beraber pisirildi...");
        }

        public void krema()
        {
            Console.WriteLine("Tavuk etleri kremayla beraber soslandı...");
        }
    }
}
