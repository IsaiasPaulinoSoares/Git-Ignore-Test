using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class Membros
    {
       public string nome;
        public int idade;

        public static void Executar()
        {
            Membros sicrano = new Membros();
            sicrano.nome = "Emanuel";
            sicrano.idade = 21;
            Console.WriteLine($"{sicrano.nome} tem {sicrano.idade} anos");
            //return string.Format($"{sicrano.nome} tem {sicrano.idade} anos");

        }
        
    }
}
