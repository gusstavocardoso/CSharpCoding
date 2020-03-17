using System;

namespace Propriedades.Proriedades
{
    class Person // Propriedade
    {
        public string Nome { get; set;}
        public int Idade { get; set;}
        public char Sexo { get; set; }
    }

    class Propriedades
    {
        static void Main(string[] args)
        {
            Person Pessoa = new Person(); // Person chama a classe da propriedade
            Console.WriteLine("Qual é o seu nome?");
            Pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            Pessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu sexo?");
            Pessoa.Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é " + Pessoa.Nome + " e você tem " + Pessoa.Idade + " e é do sexo " + Pessoa.Sexo);
        }
    }
}
