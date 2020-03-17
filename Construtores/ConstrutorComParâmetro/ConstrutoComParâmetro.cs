using System;

namespace Construtores.ConstrutorComParâmetro
{
    class Guitarra //Classe
    {
        public string modelo;
        public string marca;

        public Guitarra(string nomeModelo, String nomeMarca) //Construtor da classe com parâmentros
        {
            modelo = nomeModelo;
            
            marca = nomeMarca;
        }
        static void Main(string[] args)
        {
            Guitarra Ibanez = new Guitarra("JEM", "Ibanez");
            Console.WriteLine(Ibanez.marca + " " + Ibanez.modelo);
        }
    }
}
