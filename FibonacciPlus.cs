using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace study
{
    class FibonacciPlus
    {
        public static void Executar()
        {
            double n;

            // Lê a posição do termo
            Console.WriteLine("Digite a posicao: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine(n.ToString("F2"));

            /*void fibonacci() {
                
            }

            

        // Função fibonacci
         public void fibonacci(int n)
            {
                if (n == 1)
                   Console.WriteLine(0);
                else if (n == 2)
                   Console.WriteLine(1);
                else
                    Console.WriteLine((n - 1) + (n - 2));
            }*/
        }   
    }
}
