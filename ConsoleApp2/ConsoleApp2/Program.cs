using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HeroName = "Garelt";
            int HeroPower = 100;
            string VillainName = "wild hunt";
            int VillainPower = 95;
            if (HeroPower < VillainPower) 
            {
                Console.WriteLine(" The Villain is powerfull than the Hero ");
            }
            else if ( HeroPower == VillainPower )
            {
                Console.WriteLine(" None is powerfull "); 
            }
            else
            {
                Console.WriteLine(" The Hero is powerfull than the Villain ");
            }
        }
    }
}
