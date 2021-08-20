using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class FactoryCreator
    {
        IKrediKartiFactory krediKartıFactory;
        public KartNumarasi kartNo;
        public KartSahibi kartSahibi;
        public KartSonKullanmaTarihi sonKullanmaTarihi;

        public FactoryCreator(IKrediKartiFactory _KrediKartı)
        {
            this.krediKartıFactory = _KrediKartı;
            this.kartNo = this.krediKartıFactory.KartNumarasiYarat();
            this.kartSahibi = this.krediKartıFactory.KartSahibiYarat();
            this.sonKullanmaTarihi = this.krediKartıFactory.KartSonKullanmaTarihiYarat();
        }
    }
}
