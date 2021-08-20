using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
     public class VisaFactory : IKrediKartiFactory
    {
        public KartNumarasi KartNumarasiYarat()
        {
            return new VisaKartNo();
        }

        public KartSahibi KartSahibiYarat()
        {
            return new VisaKartSahibi();
        }

        public KartSonKullanmaTarihi KartSonKullanmaTarihiYarat()
        {
            return new VisaKartSonKullanmaTarihi();
        }

    }
}
