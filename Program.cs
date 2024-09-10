using System;

namespace PontosVidaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite os pontos de vida iniciais: ");
            int pontosVidaIniciais = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o aumento de vida por nível: ");
            int aumentoPorNivel = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o nível atual do personagem: ");
            int nivelAtual = int.Parse(Console.ReadLine());

            // Solicitar o novo nível que o personagem deseja alcançar
            Console.Write("Digite o novo nível que o personagem deseja alcançar: ");
            int novoNivel = int.Parse(Console.ReadLine());

           
            int pontosVidaFinais = pontosVidaIniciais + (novoNivel - nivelAtual) * aumentoPorNivel;

            
            Console.WriteLine($"\nQuantidade de pontos de vida após alcançar o nível {novoNivel}: {pontosVidaFinais}");
        }
    }
}
