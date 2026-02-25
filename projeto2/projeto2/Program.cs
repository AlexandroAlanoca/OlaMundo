using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 19;
            double precoProduto = 1.99;
            char sexo = 'f';
            string nome = "Elias";
            bool ligado = true;

            Console.WriteLine(idade);
            Console.WriteLine(precoProduto);
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
            Console.WriteLine(ligado);

            Console.WriteLine("Olá " + nome);
            int x = 3;
            int y = 2;
            Console.WriteLine(x + y);

            Console.WriteLine("Digite o nome de usuário: ");
            string userName = Console.ReadLine();
            Console.WriteLine("O nome de usuário é " + userName);

        }
    }
}
