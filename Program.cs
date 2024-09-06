using System;

class Program
{
    static void Main()
    {
        // Solicita que o usuário insira uma string
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        // Converte a string para minúscula para facilitar a contagem
        string lowerInput = input.ToLower();

        // Inicializa a contagem
        int count = 0;

        // Percorre a string e conta quantas vezes 'a' aparece
        foreach (char c in lowerInput)
        {
            if (c == 'a')
            {
                count++;
            }
        }

        // Exibe o resultado
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }
}