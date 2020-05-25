using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Digite um numero para gerar a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            ImprimiTabuada(numero);
            Console.Read();
        }
        public static void ImprimiTabuada(int numero)
        {
            int resultado = 0;

            for (int n1 = 0; n1 <= 10; n1++)
            {
                resultado = n1 * numero;
                Console.WriteLine(numero + " X " + n1 + " = " + resultado);
            }
        }
    }
}
