﻿using System;

namespace Fundamentos.EstruturaCondicional
{
    class EstruturaCondicional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}
