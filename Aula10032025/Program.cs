using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1___10_03_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Digite o prmeiro Número");
            a = Convert.ToInt32(Console.ReadLine());//pega o valor digitado e transforma em int 
            Console.WriteLine("Digite o segundo Número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A soma de {a} e {b} é: {a + b}");//exibindo o valor da soma
            Console.ReadKey();

            float c = 0;
            float d = 0;

            Console.WriteLine("Digite o terceiro Número");
            c = Convert.ToInt32(Console.ReadLine());//pega o valor digitado e transforma em int 
            Console.WriteLine("Digite o quarto Número");
            d = Convert.ToInt32(Console.ReadLine());
            
            if (d == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
                Console.WriteLine($"A divisão de {c} e {d} é: {c / d}");//exibindo o valor da divisão
            }
       
            Console.ReadKey();


        }
    }
}
