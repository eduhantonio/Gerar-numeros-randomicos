using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            int numero = numAleatorio.Next(1, 10);
            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}
