using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._1_while___10_03_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int c = 0;
            int d = 0;

            Console.WriteLine("Digite o terceiro Número");
            c = Convert.ToInt32(Console.ReadLine());//pega o valor digitado e transforma em int 
            Console.WriteLine("Digite o quarto Número");
            d = Convert.ToInt32(Console.ReadLine());

            while (d == 0)
            {
                Console.WriteLine("Zero não pode!Digite outro número:");
                d = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"A divisão de {c} e {d} é: {c / d}");
            Console.ReadKey();

            //raiz quadrada:

            Console.WriteLine($"A raiz quadrada de {c} é: {Math.Sqrt(c)}, e a raiz de {d} é: {Math.Sqrt(d)}");
            Console.ReadKey();

        }
    }
}
