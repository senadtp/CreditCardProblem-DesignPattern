using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class VisaKartSahibi : KartSahibi
    {
        public override string kartSahibi { get => base.kartSahibi; set => base.kartSahibi = value; }
    }
}
