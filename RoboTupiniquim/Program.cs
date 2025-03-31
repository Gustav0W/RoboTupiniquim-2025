namespace RoboTupiniquim.ConsoleApp
{
    public class Program
    {       
        public static bool prosseguir = false;
        static void Main(string[] args)
        {

            Grid.GerarGrid();
          
            Robos.PosicionarRobo1();

            Robos.PosicionarRobo2();

            Cardeais.GerarCardeaisDoRobo1();

            Cardeais.GerarCardeaisDoRobo2();

            Robos.MovimentarRobo1();

            Robos.MovimentarRobo2();

            Console.Write($"\nPosição nova do robô 1: {Robos.posicaoX1} {Robos.posicaoY1} {Cardeais.Direcao1}");
            Console.Write($"\nPosição nova do robô 2: {Robos.posicaoX2} {Robos.posicaoY2} {Cardeais.Direcao2}");
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
            
            
            
    


