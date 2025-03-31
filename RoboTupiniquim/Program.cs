namespace RoboTupiniquim.ConsoleApp
{
    public class Program
    {
            public static string coordenadaMaxX = default!;
            public static string coordenadaMaxY = default!;
            public static bool prosseguir = false;
            public static string inicialRobo1, inicialRobo2;
            public static int posicaoX1 = default, posicaoX2 = default;
            public static int posicaoY1 = default, posicaoY2 = default;            
            public static bool N1 = false, L1 = false, S1 = false, O1 = false, N2 = false, L2 = false, S2 = false, O2 = false;
            public static char Direcao1, Direcao2, auxDirecao2 = ' ', auxPosicaoX2 = ' ', auxPosicaoY2 = ' ', auxDirecao1 = ' ', auxPosicaoX1 = ' ', auxPosicaoY1 = ' ';
        static void Main(string[] args)
        {

            Grid.GerarGrid();

            //Posição inicial do robô 1
            Robos.PosicionarRobo1();

            //Posição do robô 2
            Robos.PosicionarRobo2();

            //Lógica cardeal
            Cardeais.GerarCardeaisDoRobo1();
            //Lógica cardeal robô 2
            Cardeais.GerarCardeaisDoRobo2();

            //Movimentação do robô 1
            Robos.MovimentarRobo1();

            //Movimentação do robô 2
            Robos.MovimentarRobo2();

            Console.Write($"\nPosição nova do robô 1: {posicaoX1} {posicaoY1} {Direcao1}");
            Console.Write($"\nPosição nova do robô 2: {posicaoX2} {posicaoY2} {Direcao2}");
            Console.Write("Aperte ENTER para encerrar");
            Console.ReadLine();
        }       
        public static void Cabecalho()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("     Robôs Tupiniquins     ");
            Console.WriteLine("===========================");
        }      
    }
}
            
            
            
    


