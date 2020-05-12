using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace study
{
    class VariaveisEConstantes
    {
        public static void /*static double*/ Executar(){
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            
            raio = 5.5;
            
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);
            //return area;
            //float new b = [ 1, 2, 3, 4, 5 ];
            bool teste = true;
            if(teste == true)
            {
                for (int s = 0; s <= 5; s++)
                {
                    int x = 0;
                    do
                    {
                        Console.WriteLine("oi do while" + x);
                        x++;
                    } while (x >= 10);
                }
            }
        }
    }
}
