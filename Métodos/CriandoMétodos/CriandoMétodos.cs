using System;

namespace Métodos.CriandoMétodos
{
    class CriandoMétodos
    {
        static void Metodos()
        {
            Console.WriteLine("Você está criando um método!");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é " + nome + " e você tem " + idade + " anos");
        }
        static void Main(string[] args)
        {
            Metodos();
        }
    }
}
