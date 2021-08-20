using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public interface IKrediKartiFactory
    {
        KartNumarasi KartNumarasiYarat();

        KartSahibi KartSahibiYarat();

        KartSonKullanmaTarihi KartSonKullanmaTarihiYarat();
    }
}
