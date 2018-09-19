using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {//Board

                Board();
                Console.WriteLine("Hru ukoncis zadanim 'exit'.");
                Console.WriteLine("Zadej souřadnice:");
                string cons = Console.ReadLine();
                cons.Substring(0, 1);
                cons.Substring(1, 1);
                cons = cons.ToUpper();
                char column = cons[0];
                char row = cons[1];
                int num = cons[0];
                bool result = Int32.TryParse(cons, out num);

                string validChars = "ABCDEFGHIJ";

                if (cons == "EXIT")
                {
                    return;
                }

                else if (!validChars.Contains(column) || (num >= 11))
                {
                    Console.WriteLine("Použij znak od A do J, a číslice od 1 do 10. Například: 'C2'");
                }
                Console.WriteLine("Sloupec = {1}, Řádek = {0}", row, column);

                if (result == false)
                {
                    Console.WriteLine("Nezáhnul jsi nic!");
                }
                else
                {
                    Console.WriteLine("Zasáhnul jsi soupeře!");
                }

            }
        }
        public static void Board()
        {

            Console.WriteLine("\n");
            Console.WriteLine("     |  A  |  B  |  C  |  D  |  E  |  F  |  G  |  H  |  I  |  J  |");
            Console.WriteLine("-----+-----:-----:-----:-----:-----:-----:-----:-----:-----:-----:");

            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write(" {0} ", i + 1);
                }
                else
                    Console.Write(" {0}  ", i + 1);

                Console.Write(" |\r\n");
                Console.WriteLine("-----+-----:-----:-----:-----:-----:-----:-----:-----:-----:-----:");
            }
            Console.Write("\n");
        }

    }
}
