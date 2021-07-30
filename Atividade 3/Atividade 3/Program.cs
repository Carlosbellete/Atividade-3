using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos agora resolver um problema");
            Console.WriteLine("As letras representam os seguintes valore:");
            Console.Write("X = ");
            string x = Console.ReadLine();
            Console.Write("y = ");
            string y = Console.ReadLine();
            Console.Write("z = ");
            string d = Console.ReadLine();
            string resultado = x + y + d + (5 * 77 + 8 -  10 * (8 / 3));
            Console.WriteLine("Sendo assim, o resultado da expressão?" + resultado);
        }
    }
}
