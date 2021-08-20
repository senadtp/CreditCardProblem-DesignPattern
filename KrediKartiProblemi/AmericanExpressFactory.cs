using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class AmericanExpressFactory : IKrediKartiFactory
    {
        public KartNumarasi KartNumarasiYarat()
        {
            return new AmericanExpressKartNo();
        }

        public KartSahibi KartSahibiYarat()
        {
            return new AmericanExpressKartSahibi();
        }

        public KartSonKullanmaTarihi KartSonKullanmaTarihiYarat()
        {
            return new AmericanExpressKartSonKullanmaTarihi();
        }
    }
}
