using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class VisaKartNo : KartNumarasi
    {
        public override string kartNumarasi
        {
            get => base.kartNumarasi;
            set
            {
                if ((value.Length == 13 || value.Length == 16) &&value.Substring(0, 1) == "4")
                {
                    base.kartNumarasi = value;
                }

            }
        }

    }
}
