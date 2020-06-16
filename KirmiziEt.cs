using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtDunyasi
{
    //TEMPLATE YAZILIM TASARIM DESENİ KULLANILDI.
    class KirmiziEt : EtDunyasi , IEtSosu
    {
        public override void kesimSekli()
        {
            Console.WriteLine("Etler kup kup kesildi...");
        }

        public override void sunum()
        {
            Console.WriteLine("Etler pilavla servis edildi...");
        }

        public void biber()
        {
            Console.WriteLine("Etler biberlerle beraber pisirildi...");
        }

        public void salca()
        {
            Console.WriteLine("Biberle pisen et salca ile soslandı...");
        }
    }
}
