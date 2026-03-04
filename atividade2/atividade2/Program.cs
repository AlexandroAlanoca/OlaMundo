using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter username: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);*/

            //exerciocio 1
            
            Console.WriteLine("Escreva o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva o seu ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            ano = 2026 - ano;
            Console.WriteLine("O seu nome é: " + nome);
            Console.WriteLine("A sua idade é: " + ano);

            //exercicio 2

            Console.WriteLine("Digite a quantidade de dolares: ");
            int dolar = Convert.ToInt32(Console.ReadLine());
            double dolarConvertidoReal = 5.1 * dolar;
            Console.WriteLine("Os dolares convertidos em reais é R$" + dolarConvertidoReal);

            //exercicio 3
            
            Console.WriteLine("Qual o valor da base do retângulo: ");
            int baseRetangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o valor da altura do retângulo: ");
            int alturaRetangulo = Convert.ToInt32(Console.ReadLine());
            int areaRetangulo = baseRetangulo * alturaRetangulo;
            Console.WriteLine("A área do retângulo é " + areaRetangulo);

            //exercicio 4

            Console.WriteLine("Valor exibido com as 2 casas decimais é ");
            Console.WriteLine(dolarConvertidoReal.ToString("F2"));
        }
    }
}
