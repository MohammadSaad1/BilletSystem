using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MCØresund : KøreTøj
    {
        private const int BroBizzPris = 73;

        public MCØresund() 
            : base(210)
        {
        }

        public override string KøreTøjType()
        {
            return "Øresund MC";
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
