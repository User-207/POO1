using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Boa noite!");
            Console.WriteLine("Qual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine()); //converter a string para int

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine($"O(a) {nome} tem {idade} anos de vida!");// modo de incluir as variáveis dentro da string, através do $
            Console.ReadKey();
        }
    }
}
