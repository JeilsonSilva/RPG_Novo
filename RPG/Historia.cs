using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Historia
    {
        public string Nome_Jogo = "Pesadelo";
        public string jogador = "";
        public int escolha;
        public int opções;



        public Historia()
        {
        volta:
            Console.WriteLine("===============================");
            Console.WriteLine("=========Bem vindo ao==========");
            Console.WriteLine($"============{Nome_Jogo}===========");
            Console.WriteLine("===============================");
            Console.WriteLine();


      
            Console.WriteLine("Escolha uma opção a seguir:");
            Console.WriteLine("[1]Iniciar\n[2]Opções\n[3]Sair");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Console.WriteLine("Qual é o seu nome?");
                    jogador = Console.ReadLine();
                    Console.Clear();
                    texto();

                    break;


                case 2:

                    Console.Clear();
                    Console.WriteLine("Escolha uma opção a seguir:");
                    Console.WriteLine("[1]Sem tempo irmão\n[2]Sair");
                    opções = int.Parse(Console.ReadLine());
                    Console.Clear();
                    goto volta;


                case 3:
                    goto sair;


                default:

                    Console.Clear();
                    Console.WriteLine("Erro 55");
                    Console.ReadLine();
                    Console.Clear();
                    goto volta;
                  
            }


        sair: { }
        }


        private async Task texto()
        {
            _ = pontos();
            Console.WriteLine($"{jogador} você acorda em uma masmorra e tudo está meio escuro.Você sente um de seus pulsos " +
             "preso junto ao seu corpo e escuta fortes barulhos vindos do corredor. Seus olhos começam a pesar.");
            Console.WriteLine();

            Console.WriteLine("Você acorda no meio de uma sala quadrada e nela existem 4 portas," +
                                    " uma em cada parede.Seus pulsos agora estão livres");
            Console.ReadLine();
            Console.Clear();
            Jogo jog = new Jogo();
           

        }
        private async Task pontos()
        {
            await Task.Delay(100);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Carregando");
            for (int i = 0; i <= 15; i++)
            {
                Console.Write(".");
                await Task.Delay(400);

            }

            Console.WriteLine(".");
            Console.Write("Pressione Enter:");
         

        }
    }
}