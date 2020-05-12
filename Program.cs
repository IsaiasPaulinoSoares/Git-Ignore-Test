using System;
using System.Collections.Generic;

using study;

namespace Central {
    class Program {
        private Dictionary<string, Action> dictionary;

        static void Main(string[] args) {
            var Central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa", PrimeiroPrograma.Executar},
                {"Comentários - Teste", Comentarios.Executar},
                {"Variáveis, Constantes e Estruturas", VariaveisEConstantes.Executar},
                {"Fibonacci com Incrementos", Fibonacci_Simples.Executar},
                {"Fibonacci Plus", FibonacciPlus.Executar},
                {"Membros", Membros.Executar},

            });

            Central.SelecionarEExecutar();
        }
    }
}