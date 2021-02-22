using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voornaam: ");
            string Vnaam = Console.ReadLine();
            Console.WriteLine("Achternaam: ");
            string Anaam = Console.ReadLine();
            Console.WriteLine("Straat: ");
            string Straat = Console.ReadLine();
            Console.WriteLine("Nummer: ");
            string Nummer = Console.ReadLine();
            Console.WriteLine("Stad: ");
            string Stad = Console.ReadLine();
            Console.WriteLine("PostCode: ");
            string PC = Console.ReadLine();
            Console.WriteLine("naam : {0} {1}\nAdress : {2} {3}, {4} {5}",Vnaam,Anaam,Straat,Nummer,Stad,PC);
            Console.ReadLine();
        }
    }
}
