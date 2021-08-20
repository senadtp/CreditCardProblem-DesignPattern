using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class MasterCardFactory : IKrediKartiFactory
    {
        public KartNumarasi KartNumarasiYarat()
        {
            return new MasterCardKartNo();
        }

        public KartSahibi KartSahibiYarat()
        {
            return new MasterCardKartSahibi();
        }

        public KartSonKullanmaTarihi KartSonKullanmaTarihiYarat()
        {
            return new MasterCardKartSonKullanmaTarihi();
        }

       
    }
}
