using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : KøreTøj
    {

        //private const int GrundPris = 125;
        public override string KøreTøjType()
        {
            return "MC";
        }

        public override int Pris()
        {
            if (BroBizz)
                return GrundPris * 95 / 100;

            return GrundPris;
        }

        public MC()
            :base(125)
        {

        }
    }
}
