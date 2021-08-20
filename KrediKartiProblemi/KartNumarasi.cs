using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiProblemi
{
 
    public abstract class KartNumarasi
    {
        private string kartNo;

        public virtual string kartNumarasi
        {
            get { return kartNo; }
            set { kartNo = value; }
        }
    }
}
