namespace RoboTupiniquim.ConsoleApp
{
    internal class Robos
    {
        public static string inicialRobo1 = "", inicialRobo2 = "";
        public static int posicaoX1 = default, posicaoX2 = default;
        public static int posicaoY1 = default, posicaoY2 = default;
        public static char auxDirecao2 = ' ', auxPosicaoX2 = ' ', auxPosicaoY2 = ' ', auxDirecao1 = ' ', auxPosicaoX1 = ' ', auxPosicaoY1 = ' ';
        public static void PosicionarRobo1()
        {
            do
            {
                Program.prosseguir = false;
                Console.Clear();
                Program.Cabecalho();

                Console.Write("Informe a posição inicial e  do robô 1 (Exemplo.:1 3 N): ");
                inicialRobo1 = Console.ReadLine()!.ToUpper().Trim();

                auxPosicaoY1 = inicialRobo1[2];
                auxPosicaoX1 = inicialRobo1[0];
                Cardeais.Direcao1 = inicialRobo1[4];
                auxDirecao1 = inicialRobo1[4];
                if (inicialRobo1[1] != ' ' || inicialRobo1[3] != ' ')
                {
                    Console.WriteLine("Apenas espaços para separar os valores (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (!int.TryParse(auxPosicaoX1.ToString(), out posicaoX1) || !int.TryParse(auxPosicaoY1.ToString(), out posicaoY1))
                {
                    Console.WriteLine("Número inválido, tente novamente (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Cardeais.Direcao1 != 'N' && Cardeais.Direcao1 != 'S' && Cardeais.Direcao1 != 'L' && Cardeais.Direcao1 != 'O')
                {
                    Console.Write("O último valor deve ser uma letra indicando pontos cardeais (N - Norte, L - Leste, S - Sul, O - Oeste)");
                    Console.Write("\n Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                else if (posicaoX1 < 0 || posicaoY1 < 0)
                {
                    Console.Write("Por favor, não use números negativos (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (posicaoX1 > Convert.ToInt32(Grid.coordenadaMaxX) || posicaoY1 > Convert.ToInt32(Grid.coordenadaMaxY))
                {
                    Console.Write("Os números informados são maiores que o valor do grid (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                Program.prosseguir = true;
            } while (Program.prosseguir == false);
        }
        public static void PosicionarRobo2()
        {
            do
            {
                Program.prosseguir = false;
                Console.Clear();
                Program.Cabecalho();

                Console.Write("Informe a posição inicial e  do robô 2 (Exemplo.:1 3 N): ");
                inicialRobo2 = Console.ReadLine()!.ToUpper().Trim();

                auxPosicaoY2 = inicialRobo2[2];
                auxPosicaoX2 = inicialRobo2[0];
                Cardeais.Direcao2 = inicialRobo2[4];
                auxDirecao2 = inicialRobo2[4];

                if (inicialRobo2[1] != ' ' || inicialRobo2[3] != ' ')
                {
                    Console.WriteLine("Apenas espaços para separar os valores (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (!int.TryParse(auxPosicaoX2.ToString(), out posicaoX2) || !int.TryParse(auxPosicaoY2.ToString(), out posicaoY2))
                {
                    Console.WriteLine("Número inválido, tente novamente (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (posicaoX2 < 0 || posicaoY2 < 0)
                {
                    Console.Write("Por favor, não use números negativos (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (posicaoX2 > Convert.ToInt32(Grid.coordenadaMaxX) || posicaoY2 > Convert.ToInt32(Grid.coordenadaMaxY))
                {
                    Console.Write("Os números informados são maiores que o valor do grid (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (posicaoX2 == posicaoX1 && posicaoY2 == posicaoY1)
                {
                    Console.Write("Os dois robôs não podem ocupar o mesmo espaço. (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Cardeais.Direcao2 != 'N' && Cardeais.Direcao2 != 'S' && Cardeais.Direcao2 != 'L' && Cardeais.Direcao2 != 'O')
                {
                    Console.Write("O último valor deve ser uma letra indicando pontos cardeais (N - Norte, L - Leste, S - Sul, O - Oeste)");
                    Console.Write("\n Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                Program.prosseguir = true;
            } while (Program.prosseguir == false);
        }
        public static void MovimentarRobo1()
        {
            do
            {
                Console.Clear();
                Program.Cabecalho();

                Console.Write("Movimentação do Robô 1 \n");
                Console.Write($"Posição atual: X:{posicaoX1} Y:{posicaoY1} Direção:{Cardeais.Direcao1}\n");
                Console.WriteLine("----------------------------------------------------------");

                Console.Write("Quantas ações irão ser executadas ?: ");
                if (!int.TryParse(Console.ReadLine(), out int totalAcoes))
                {
                    Console.WriteLine("Entrada inválida, tente novamente");
                    Console.Write("Pressione ENTER para continuar");
                    Console.ReadLine();
                    Program.prosseguir = false;
                    continue;
                }

                Console.Write("\nInforme toda a movimentação do robô 1(E - 90º Esquerda | D - 90º Direita | M - Mover para frente): ");
                string movimentacoes = Console.ReadLine()!.ToUpper().Trim();

                for (int i = 0; i < totalAcoes; i++)
                {
                    if (movimentacoes[i] == 'E')
                    {
                        if (Cardeais.N1 == true)
                        {
                            Cardeais.N1 = false;
                            Cardeais.O1 = true;
                            Cardeais.Direcao1 = 'O';
                        }
                        else if (Cardeais.O1 == true)
                        {
                            Cardeais.O1 = false;
                            Cardeais.S1 = true;
                            Cardeais.Direcao1 = 'S';
                        }
                        else if (Cardeais.S1 == true)
                        {
                            Cardeais.S1 = false;
                            Cardeais.L1 = true;
                            Cardeais.Direcao1 = 'L';
                        }
                        else if (Cardeais.L1 == true)
                        {
                            Cardeais.L1 = false;
                            Cardeais.N1 = true;
                            Cardeais.Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (Cardeais.N1 == true)
                        {
                            Cardeais.N1 = false;
                            Cardeais.L1 = true;
                            Cardeais.Direcao1 = 'L';
                        }
                        else if (Cardeais.L1 == true)
                        {
                            Cardeais.L1 = false;
                            Cardeais.S1 = true;
                            Cardeais.Direcao1 = 'S';
                        }
                        else if (Cardeais.S1 == true)
                        {
                            Cardeais.S1 = false;
                            Cardeais.O1 = true;
                            Cardeais.Direcao1 = 'O';
                        }
                        else if (Cardeais.O1 == true)
                        {
                            Cardeais.O1 = false;
                            Cardeais.N1 = true;
                            Cardeais.Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (Cardeais.N1 == true)
                            posicaoY1 = posicaoY1 + 1;
                        if (Cardeais.L1 == true)
                            posicaoX1 = posicaoX1 + 1;
                        if (Cardeais.S1 == true)
                            posicaoY1 = posicaoY1 - 1;
                        if (Cardeais.O1 == true)
                            posicaoX1 = posicaoX1 - 1;
                    }

                }
                if (posicaoX1 < 0 || posicaoY1 < 0 || posicaoX1 > Convert.ToInt32(Grid.coordenadaMaxX) || posicaoY1 > Convert.ToInt32(Grid.coordenadaMaxY))
                {
                    Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                    posicaoX1 = Convert.ToInt32(auxPosicaoX1.ToString());
                    posicaoY1 = Convert.ToInt32(auxPosicaoY1.ToString());
                    Cardeais.Direcao1 = auxDirecao1;
                    Program.prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                Program.prosseguir = true;
            } while (Program.prosseguir == false);
        }
        public static void MovimentarRobo2()
        {
            do
            {
                Console.Clear();
                Program.Cabecalho();

                Console.Write("Movimentação do Robô 2 \n");
                Console.Write($"Posição atual: X:{posicaoX2} Y:{posicaoY2} Direção:{Cardeais.Direcao2}\n");
                Console.WriteLine("----------------------------------------------------------");

                Console.Write("Quantas ações irão ser executadas ?: ");
                if (!int.TryParse(Console.ReadLine(), out int totalAcoes))
                {
                    Console.WriteLine("Entrada inválida, tente novamente");
                    Console.Write("Pressione ENTER para continuar");
                    Console.ReadLine();
                    Program.prosseguir = false;
                    continue;
                }

                Console.Write("\nInforme toda a movimentação do robô 2 (E - 90º Esquerda | D - 90º Direita | M - Mover para frente): ");
                string movimentacoes = Console.ReadLine()!.ToUpper().Trim();

                for (int i = 0; i < totalAcoes; i++)
                {
                    if (movimentacoes[i] == 'E')
                    {
                        if (Cardeais.N2 == true)
                        {
                            Cardeais.N2 = false;
                            Cardeais.O2 = true;
                            Cardeais.Direcao2 = 'O';
                        }
                        else if (Cardeais.O2 == true)
                        {
                            Cardeais.O2 = false;
                            Cardeais.S2 = true;
                            Cardeais.Direcao2 = 'S';
                        }
                        else if (Cardeais.S2 == true)
                        {
                            Cardeais.S2 = false;
                            Cardeais.L2 = true;
                            Cardeais.Direcao2 = 'L';
                        }
                        else if (Cardeais.L2 == true)
                        {
                            Cardeais.L2 = false;
                            Cardeais.N2 = true;
                            Cardeais.Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (Cardeais.N2 == true)
                        {
                            Cardeais.N2 = false;
                            Cardeais.L2 = true;
                            Cardeais.Direcao2 = 'L';
                        }
                        else if (Cardeais.L2 == true)
                        {
                            Cardeais.L2 = false;
                            Cardeais.S2 = true;
                            Cardeais.Direcao2 = 'S';
                        }
                        else if (Cardeais.S2 == true)
                        {
                            Cardeais.S2 = false;
                            Cardeais.O2 = true;
                            Cardeais.Direcao2 = 'O';
                        }
                        else if (Cardeais.O2 == true)
                        {
                            Cardeais.O2 = false;
                            Cardeais.N2 = true;
                            Cardeais.Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (Cardeais.N2 == true)
                            posicaoY2 = posicaoY2 + 1;
                        if (Cardeais.L2 == true)
                            posicaoX2 = posicaoX2 + 1;
                        if (Cardeais.S2 == true)
                            posicaoY2 = posicaoY2 - 1;
                        if (Cardeais.O2 == true)
                            posicaoX2 = posicaoX2 - 1;
                    }
                }
                if (posicaoX2 < 0 || posicaoY2 < 0 || posicaoX2 > Convert.ToInt32(Grid.coordenadaMaxX) || posicaoY2 > Convert.ToInt32(Grid.coordenadaMaxY))
                {
                    Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                    posicaoX2 = Convert.ToInt32(auxPosicaoX2.ToString());
                    posicaoY2 = Convert.ToInt32(auxPosicaoY2.ToString());
                    Cardeais.Direcao2 = auxDirecao2;
                    Program.prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                if (posicaoX2 == posicaoX1 && posicaoY2 == posicaoY1)
                {
                    Console.WriteLine("Assim os robôs vão bater po!!!!!");
                    Console.Write("Pressione ENTER para continuar");
                    posicaoX2 = Convert.ToInt32(auxPosicaoX2.ToString());
                    posicaoY2 = Convert.ToInt32(auxPosicaoY2.ToString());
                    Cardeais.Direcao2 = auxDirecao2;
                    Program.prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                Program.prosseguir = true;
            } while (Program.prosseguir == false);
        }
    }
}
