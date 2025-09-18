using System;
using System.Data; // Necessário para avaliar expressões matemáticas

namespace ScientificCalculator
{
    // Classe que representa uma calculadora simples
    public class CalculadoraSimples
    {
        // Método para calcular o resultado de uma expressão
        public string Calcular(string expressao)
        {
            try
            {
                // Cria um objeto DataTable para avaliar a expressão
                DataTable dt = new DataTable();
                // Calcula o resultado da expressão
                var resultado = dt.Compute(expressao, null);
                // Retorna o resultado como string
                return resultado.ToString();
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna a mensagem de erro
                return $"Erro: {ex.Message}. Verifique a expressão.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora Simples em C#!");
            Console.WriteLine("Operações suportadas: +, -, *, /");
            Console.WriteLine("Digite 'sair' para fechar a calculadora.");

            // Cria uma instância da nossa calculadora
            CalculadoraSimples minhaCalculadora = new CalculadoraSimples();

            while (true)
            {
                Console.Write("Digite a expressão: ");
                string input = Console.ReadLine();

                // Verifica se o usuário quer sair
                if (input.ToLower() == "sair")
                {
                    break;
                }

                // Chama o método Calcular da nossa calculadora
                string resultado = minhaCalculadora.Calcular(input);
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("Obrigado por usar a calculadora!");
        }
    }
}
