using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
    public class MasterCardKartNo : KartNumarasi
    {
        public override string kartNumarasi
        {
            get => base.kartNumarasi;
            set
            {
                if (value.Substring(0, 1) == "5" && Convert.ToInt32(value.Substring(1, 1)) > 0 && Convert.ToInt32(value.Substring(1, 1)) < 6 && value.Length == 16)
                {
                    base.kartNumarasi = value;
                }

            }
        }

    }
}
