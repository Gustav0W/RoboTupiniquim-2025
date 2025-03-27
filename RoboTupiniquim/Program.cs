namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inicialRobo1;
            string coordenadaMaxX = default;
            string coordenadaMaxY = default;
            bool prosseguir = false;
            //Cabeçalho
            Console.WriteLine("===========================");
            Console.WriteLine("     Robôs Tupiniquins     ");
            Console.WriteLine("===========================");
            //Grid
            do
            {
                Console.Write("Informe os valores que representarão a malha (X Y): ");
                string grid = Console.ReadLine()!;
                if (grid[1] != ' ')
                {
                    Console.WriteLine("Utilize apenas espaços para separar os valores\n");
                    continue;
                }
                else
                {
                    coordenadaMaxX = grid[0].ToString();
                    coordenadaMaxY = grid[2].ToString();
                }
                if (coordenadaMaxX == "0" || coordenadaMaxY == "0")
                {
                    Console.WriteLine("Número nulo, coloque valores acima de 0");
                    continue;
                }
                else
                {
                    prosseguir = true;
                }
            } while (prosseguir == false);
            //Posição inicial do robô 1
            do
            {
                prosseguir = false;

                Console.Write("Informe a posição inicial e  do robô 1 (Exemplo.:1 3 N): ");
                inicialRobo1 = Console.ReadLine()!;

                char posicaoX1 = inicialRobo1[0];
                char posicaoY1 = inicialRobo1[2];
                char direcao1 = inicialRobo1[4];
                if (inicialRobo1[1] != ' '|| inicialRobo1[3] != ' ')
                {
                    Console.WriteLine("Apenas espaços para separar os valores");
                    continue;
                }
                else
                {

                }
            } while (prosseguir == false);


            Console.Write("Informe a posição inicial e  do robô 2: ");
            


        }
    }
}
