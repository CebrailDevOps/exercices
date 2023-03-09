using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoEnums : iCommand
    {
        public string Name => "01_DemoEnums";

        public void Execute()
        {
            Permis permi = Permis.B;

        }
        public enum Permis
        {
            A = 0,
            B = 1,
            C = 2,
            D = 3,
            E = 4
        }
    }
}
