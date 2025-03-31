namespace RoboTupiniquim.ConsoleApp
{
    internal class Grid
    {
        public static string coordenadaMaxX = default!;
        public static string coordenadaMaxY = default!;
        public static void GerarGrid()
        {
            do
            {
                Console.Clear();
                Program.Cabecalho();
                Console.Write("Informe os valores que representarão a malha (X Y): ");
                string grid = Console.ReadLine()!;
                if (grid[1] != ' ')
                {
                    Console.WriteLine("Utilize apenas espaços para separar os valores\n");
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    coordenadaMaxX = grid[0].ToString();
                    coordenadaMaxY = grid[2].ToString();
                    if (!int.TryParse(coordenadaMaxX, out _) || !int.TryParse(coordenadaMaxY, out _))
                    {
                        Console.WriteLine("Número inválido, tente novamente (Aperte ENTER para continuar)");
                        Console.ReadLine();
                        continue;
                    }
                    if (coordenadaMaxX == "0" || coordenadaMaxY == "0")
                    {
                        Console.WriteLine("Número nulo, coloque valores acima de 0 (Aperte ENTER para continuar)");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Program.prosseguir = true;
                    }
                }
            } while (Program.prosseguir == false);
        }
    }
}

