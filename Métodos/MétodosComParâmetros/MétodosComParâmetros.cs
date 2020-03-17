using System;

namespace Métodos.Métodoscomparâmetros
{
    class MétodosComParâmetros
    {
        static void Parametros(string nome, int idade, char sexo)
        {
            Console.WriteLine("nome: " + nome + " idade: " + idade + " sexo: " + sexo);            
        }   
        static void Main(string[] args)
        {
            Parametros("Gustavo", 33, 'M');
        }     
    }
}
