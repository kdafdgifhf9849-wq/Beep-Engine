using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int o = 0;
            while (i == 0)
            {
                int.TryParse(System.Console.ReadLine(), out o);
                if (o == 1)
                {
                    System.Console.Beep(1000, 300);
                }
                else if (o == 2)
                {
                    System.Console.Beep(1500, 500);
                }
                else if (o == 3)
                {
                    i++;
                }
                else 
                {
                    i = 0;
                }
            }
        }
    }
}
