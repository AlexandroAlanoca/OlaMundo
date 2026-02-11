using System;

namespace OlaMundo
// inicio
{
    class Program
    {
        static void Main(string[] args) // método principal
        {
            Console.WriteLine("Ola Mundo"); // comando escreva
            Console.WriteLine(2 + 3);
            Console.WriteLine("2 + 3 é: " + (2 + 3));
            Console.WriteLine("2 - 3 é: " + (2 - 3));
            Console.WriteLine("2 * 3 é: " + (3 * 3));
            Console.WriteLine("2 / 3 é: " + (2 / 3));

            // declaracao de variaveis

            // tipoDoDado nomeDaVariavel

            // int (númerico inteiro -> 0)
            // double (númerico real -> 0.00)
            // bool (é um valor lógico -> V/F)
            // char (uma única letra -> ´s´)
            // string (cadeia de caracteres -> "a")

            /*int n1 = 12;
            int n2 = 12;

            Console.WriteLine(n1 + n2);
            Console.WriteLine(Math.PI);*/

            //declarar a var nome e idade
            //e apresentar: "Olá x, você tem x anos

            string nome = "Alexandro";
            int idade = 20;
            Console.WriteLine("Olá "+ (nome) + ", você tem " + (idade) + " anos");

            //declarar UMA var numerica inteira e atribuir um valor qualquer
            //apresentar seu sucessor e seu antecessor

            int numero1 = 3;
            Console.WriteLine("O antecessor de " + (numero1) + " é " + (numero1 - 1) + " e o sucessor é " + (numero1 + 1));

            // declarar DUAS variaveis numericas inteiras e calcular:
            // a soma dos quadrados dos números 
            // o quadrado da soma dos numeros 

            int nInteiro1 = 1;
            int nInteiro2 = 2;

            Console.WriteLine("A soma dos quadrados dos números " + nInteiro1 + " e " + nInteiro2 + " é " + (Math.Pow(nInteiro1, 2) + Math.Pow(nInteiro2, 2)) + " e o quadrado da soma dos números é " + Math.Pow(Math.Pow(nInteiro1, 2) + Math.Pow(nInteiro2, 2), 2));

            //-----------------------------
            /*
            Console.WriteLine("Digite o seu nome: ");
            String name = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            String age = Console.ReadLine();
            Console.WriteLine("Olá " + (name) + "!");
            Console.WriteLine("Você tem " + (age));*/

        } // fim método principal
    }
}// fim
