using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_sciccor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerScore = 0;
            int Enemyscore = 0;

            Console.WriteLine("Sten Saks Papir!");

            while(PlayerScore != 3 && Enemyscore != 0)
            {
                Console.WriteLine("Player score - " + PlayerScore + ". Enemy Score - " + Enemyscore);

            }



        }
    }
}
