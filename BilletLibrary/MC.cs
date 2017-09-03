using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : KøreTøj
    {
        public override string KøreTøjType()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }
    }
}
