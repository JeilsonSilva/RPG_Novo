using System;

namespace RPG
{
    internal class Jogo
    {
        String posição = "Sala 1";
        int escolha;
        Mapa map = new Mapa();
        public Jogo()
        {


            Sala1();

        }

        private void Sala1()
        {
            Console.Clear();
            map.Mapa1();
        volta:
            Console.WriteLine($"Você se encontra na {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1] Salão Principal\n[2] Sala 2\n[3] Sala 3" +
                                "\n[4] Sala 4\n[5] Escadas");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Salao_Principal();

                    break;

                case 2:
                    
                    Sala2();

                    break;

                case 3:
                   
                    Sala3();

                    break;

                case 4:

                    
                    Sala4();

                    break;

                case 5:

                    
                    Escadas();

                    break;

                default:
                    posição = "Sala 1";
                    goto volta;
            }

        }

        private void Salao_Principal()
        {   erro:
            Console.Clear();
            posição = "Salão Principal";
            map.Mapa1();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) { Sala1(); }
            else { goto erro; }
        }

        private void Sala2()
        {   erro:
            Console.Clear();
            posição = "Sala 2";
            map.Mapa1();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) { Sala1(); }
            else { goto erro; }
        }

        private void Sala3()
        {   erro:
            Console.Clear();
            posição = "Sala 3";
            map.Mapa1();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Sala 4");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) { Sala1(); }
            if (escolha == 2) { Sala4(); }
            else { goto erro; }
        }

        private void Sala4()
        {   erro:
            Console.Clear();
            posição = "Sala 4";
            map.Mapa1();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Sala 3");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) { Sala1(); }
            if (escolha == 2) { Sala3(); }
            else { goto erro; }
        }

        private void Escadas()
        {   erro:
            Console.Clear();
            posição = "Escadas";
            map.Mapa1();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) { Sala1(); }
            else { goto erro; }
        }
    }
}
