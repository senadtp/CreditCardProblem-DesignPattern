using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{

    public class AmericanExpressKartNo : KartNumarasi
    {
        public override string kartNumarasi
        {
            get => base.kartNumarasi;
            set
            {
                if (value.Substring(0, 1) == "3" && (value.Substring(1, 1) == "4" || value.Substring(1, 1) == "7") && value.Length == 15 )
                {
                    base.kartNumarasi = value;
                }

            }
        }

    }
}
