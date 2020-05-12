using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class Fibonacci_Simples
    {
        public static void Executar()
        {
			double num1 = 0;
			double num2 = 1;
			double aux, n;

			Console.WriteLine("Insira um valor para a sequencia");
			n = double.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				aux = num1;
				num1 = num2;
				num2 = num1 + aux;
				Console.WriteLine(num2.ToString("F2"));

			}
			Console.ReadLine();
		}
    }
}
