using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Caneta
    {
        private string cor;
        private bool tampada;

        public Caneta(string cor)
        {
            this.cor = cor;
            this.tampada = true;
        }

        public void Destampar()
        {
            if (tampada)
            {
                tampada = false;
                Console.WriteLine("A caneta foi destampada");
            }
            else
            {
                Console.WriteLine("A caneta já está destampada");
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta C1 = new Caneta("vermelha");
            C1.Destampar();

    }
}
}
