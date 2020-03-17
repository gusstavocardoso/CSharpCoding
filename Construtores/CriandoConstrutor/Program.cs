using System;

namespace Construtores.CriandoConstrutor
{
    class Guitarra //Classe
    {
        public string modelo;
        public string marca;

        public Guitarra() //Construtor da classe 
        {
            modelo = "JEM";
            
            marca = "Ibanez";
        }
        static void Main(string[] args)
        {
            Guitarra Ibanez = new Guitarra();
            Console.WriteLine(Ibanez.marca + " " + Ibanez.modelo);
        }
    }
}
