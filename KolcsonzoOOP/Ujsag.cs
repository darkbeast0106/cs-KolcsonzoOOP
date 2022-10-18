using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Ujsag : IKolcsonozheto
    {
        private string cim;
        private int kiadasEv;
        private int kiadasHet;

        public Ujsag(string cim, int kiadasEv, int kiadasHet)
        {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            this.kiadasHet = kiadasHet;
        }

        public string Cim { get => cim; set => cim = value; }
        public int KiadasEv { get => kiadasEv; set => kiadasEv = value; }
        public int KiadasHet { get => kiadasHet; set => kiadasHet = value; }

        public int MeddigKolcsonozheto()
        {
            return 0;
        }

        public string MegjelenitendoNev()
        {
            return String.Format("{0} {1}/{2}.", this.cim, this.KiadasEv, this.KiadasHet);
        }
    }
}
