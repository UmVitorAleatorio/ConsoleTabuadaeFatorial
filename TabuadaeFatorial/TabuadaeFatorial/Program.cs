using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaeFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auxS;
            do
            {
                Console.Clear();
                Console.Write("Escolha o numero da opção desejada:\n1 - Tabuada\n2 - Fatorial\n3 - Sair");
                auxS = int.Parse(Console.ReadLine());
                switch (auxS)
                {
                    case 1:
                        Tabuada();
                    break;
                    case 2:
                        Fatorial();
                    break;
                    case 3:
                        Console.Write("Pressione qualquer tecla para finalizar!");
                        Console.ReadKey();
                    break;
                    default:
                        auxS = 0;
                    break;
                }
            }while(auxS == 0);            
        }
        public static void Tabuada()
        {
            int n, m;
            Console.Clear();
            Console.WriteLine("Você escolheu Tabuada");
            Console.Write("Digite o numero que deseja ver a tabuada até o 10: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada de " + n + " até 10");
            for (int i = 0; i <= 10; i++)
            {
                m = n * i;
                Console.WriteLine(n + " X " + i + " = " + m);
            }
            Console.ReadKey();
        }
        public static void Fatorial()
        {
            int n;
            Console.Clear();
            Console.WriteLine("Você escolheu Fatorial");
            Console.Write("Digite o numero que você deseja ver o fatorial: ");
            n = int.Parse(Console.ReadLine());
            for (int i = n;i >= 1; i--)
            {
                if (i != n)
                {
                    n *= i;
                }
                Console.WriteLine(i + " = " + n);
            }
            Console.ReadKey();
        }
    }
}
