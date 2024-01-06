using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeSınıf
{
    public class muhasebeci : genelBilgi
    {
        public int primVer(int deger)
        { 
            this.maas = this.maas + deger;
            return maas; 
        }
        public int bonusVer()
        {
            return 0;
        }
    }
}
