using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExStructures2 : iCommand
    {
        public string Name => "02_ExStructures";

        public void Execute()
        {
            Celsius c;
            Fahrenheit f;
            c.Temperature = 90;
            f.Temperature = 50;

            Console.WriteLine($"{c.Temperature}°C fait {c.ToFahrenheit()}°F");
            Console.WriteLine($"{f.Temperature}°C fait {f.ToCelsius()}°F");
        }
        public struct Celsius
        {
            public double Temperature;
            public double ToFahrenheit()
            {
                return (Temperature*1.8)+32;
            }
        }
        public struct Fahrenheit
        {
            public double Temperature;
            public double ToCelsius()
            {
                return (Temperature - 32) / 1.8;
            }
        }
    }
}
