using System;
using System.Threading;

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

                    //Console.WriteLine("Qual é o seu nome?");
                    //jogador = Console.ReadLine();
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


        private void texto()
        {
            
            Console.Write($"{jogador} você acorda em uma masmorra e tudo está meio escuro.Você sente um de seus pulsos " +
             "preso junto ao seu corpo e escuta fortes barulhos vindos do corredor. Seus olhos começam a pesar.");


            pontos();
            Console.WriteLine();
            Console.WriteLine();

                Console.WriteLine("Você acorda no meio de uma sala quadrada e nela existem 4 portas," +
                                    " uma em cada parede.Seus pulsos agora estão livres");
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();
            Jogo jog = new Jogo();


        }
        private void  pontos()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write('.');
            }

                Console.WriteLine(".");
  

        }
    }
}