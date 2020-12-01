using System;

namespace Programa_o_Orientada_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            personagem objetoPersonagem1 = new personagem();

            objetoPersonagem1.nome = "Lameck";
            objetoPersonagem1.idade = 19;
            objetoPersonagem1.armadura = "Cabeçada";


            personagem objetoPersonagem2 = new personagem();

            objetoPersonagem2.nome = "Paulo";
            objetoPersonagem2.idade = 30;
            objetoPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }
    }
}
