using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    internal class ExMethodes2 : iCommand
    {
        public string Name => "02_ExMéthodes";

        public void Execute()
        {
            EQ2D[] eq1 = new EQ2D[]
            {
                new EQ2D{A=1,B=1,C=-2 },
                new EQ2D{A=1,B=1,C=1},
                new EQ2D{A=4,B=1,C=-2 }
            };

            foreach (EQ2D eq in eq1)
            {
                double? x1, x2;
                if (eq.Resoudre(out x1, out x2))
                {
                    Console.WriteLine(x1 == x2 ? $"X={x1}" : $"X1={x1} X2={x2}");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
        public struct EQ2D
        {
            public double A,B,C;
            public bool Resoudre(out double? x1, out double? x2)
            {
                x1 = null;
                x2 = null;
                if (A == 0)
                    return false;
                double delta = (Math.Pow(B, 2)) - (4 * A * C);
                if(delta < 0)
                    return false;
                x1 = (-B-Math.Sqrt(delta))/(2*A);
                x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                return true;
            }
        }
    }
}
