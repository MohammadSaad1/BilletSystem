using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class BilØreSund : KøreTøj
    {

        private const int BroBizzPris = 161;

        public BilØreSund()
            :base(410)
        {

        }

        public override string KøreTøjType()
        {
            return "Øresund Bil";
        }

        public override int Pris()
        {
            if (BroBizz)
                return BroBizzPris;
            else
                return GrundPris;

        }
    }
}
