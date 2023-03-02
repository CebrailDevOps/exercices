using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal interface iCommand
    {
        string Name { get; }

        void Execute();
    }
}
