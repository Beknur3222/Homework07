using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanklib;

namespace Homework07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank[] t34Tanks = new Tank[5];
            Tank[] pantherTanks = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tank("T-34");
                pantherTanks[i] = new Tank("Panther");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Battle {i + 1}: {t34Tanks[i].GetTankParameters()} vs {pantherTanks[i].GetTankParameters()}");

                if (t34Tanks[i] ^ pantherTanks[i])
                    Console.WriteLine("T-34 wins!");
                else
                    Console.WriteLine("Panther wins!");

                Console.WriteLine();
            }
        }
    }
}
