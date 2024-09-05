using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TargetSistemas
{
    class Exercicio
    {
        static void Fibonacci()
        {
            int x = 1, x1 = 0, x2, num = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro, positivo, e descubra se faz parte da sequencia de fibonacci:");
                num = int.Parse(Console.ReadLine());
            } while(num <= 0);

            for (int i = 0; i <= num; i++)
            {
                x2 = x + x1;
                x = x1;
                x1 = x2;

                if(x2 == num)
                {
                    Console.WriteLine("O número {0} pertence a sequencia de fibonacci.", num);
                    return;
                }
                if(x2 > num)
                {
                    Console.WriteLine("O número {0} NÃO pertence a sequencia de fibonacci.", num);
                    return;
                }
            }

        }

        static void ContemA()
        {
            int count = 0;
            Console.WriteLine("Digite uma frase e descubra quantas vezes a letra 'a' se repete nela:");
            string frase = Console.ReadLine();

            foreach (char letra in frase.ToLower())
            {
                if (letra == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine("A letra 'a' se repete {0} vezes", count);
        }

        static void ValorSoma()
        {
            int index = 12, soma = 0, k = 1;

            while (k < index)
            {
                k += 1;
                soma += k;
            }

            Console.WriteLine(soma);
        }

        static void DescubraLogicaA()
        {
            int numero = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numero);
                numero += 2;
            
        }
    }

        static void DescubraLogicaB()
        {
            int numero = 2;
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(numero);
                numero *= 2;
            }
        }

        static void DescubraLogicaC()
        {
            for (double i =0; i < 8; i++)
            {
                Console.WriteLine(Math.Pow(i,2));
            }
        }

        static void DescubraLogicaD()
        {
            for(double i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }

        static void DescubraLogicaE()
        {
            int x = 1, x1 = 0, x2;
            for (int i = 0; i < 7; i++)
            {
                x2 = x + x1;
                x = x1;
                x1 = x2;
                Console.WriteLine(x2);
            }

        }

        static void DescubraLogicaF()
        {
            //do no
        }
        static void Main(string[] args)
        {
            //Fibonacci();
            //ContemA();
            //ValorSoma();
            //DescubraLogicaA();
            //DescubraLogicaB();
            //DescubraLogicaC();
            //DescubraLogicaD();
            //DescubraLogicaE();
            Console.ReadKey();
        }

    }

}
