using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Jogo
    {
        String posição = "Sala 1";
        int escolha;
        Mapa map = new Mapa();
        public Jogo()
        {
            volta:
            map.Mapa1();
            Console.WriteLine($"Você se encontra na {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1] Salão Principal\n[2] Sala 2\n[3] Sala 3" +
                                "\n[4] Sala 4\n[5] Escadas");
            escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1:

                    Console.Clear();
                    posição = "Salão Principal";
                    map.Mapa1();
                    Console.WriteLine($"Você está na(o) {posição}");

                    break;

                case 2:
                    Console.Clear();
                    posição = "Sala 2";
                    map.Mapa1();
                    Console.WriteLine($"Você está na(o) {posição}");

                    break;

                case 3:
                    Console.Clear();
                    posição = "Sala 3";
                    map.Mapa1();
                    Console.WriteLine($"Você está na(o) {posição}");

                    break;

                case 4:

                    Console.Clear();
                    posição = "Sala 4";
                    map.Mapa1();
                    Console.WriteLine($"Você está na(o) {posição}");

                    break;

                case 5:

                    Console.Clear();
                    posição = "Escadas";
                    map.Mapa1();
                    Console.WriteLine($"Você está na(o) {posição}");

                    break;

                default:
                    posição = "Sala 1";
                    goto volta;
            }

            goto volta;
        }
    }
}
