using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            float playerSpeed = 0;

            Console.WriteLine(playerSpeed);

            void SetSpeed()
            {
                playerSpeed = 2.5F;
            }
            
            Console.WriteLine(playerSpeed);
            SetSpeed();
            Console.WriteLine(playerSpeed);

        }
    }
}
