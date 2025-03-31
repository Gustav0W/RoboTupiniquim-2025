namespace RoboTupiniquim.ConsoleApp
{
    internal class Robos
    {
        public static void PosicionarRobo1()
        {
            do
            {
                Program.prosseguir = false;
                Console.Clear();
                Program.Cabecalho();

                Console.Write("Informe a posição inicial e  do robô 1 (Exemplo.:1 3 N): ");
                Program.inicialRobo1 = Console.ReadLine()!.ToUpper().Trim();

                Program.auxPosicaoY1 = Program.inicialRobo1[2];
                Program.auxPosicaoX1 = Program.inicialRobo1[0];
                Program.Direcao1 = Program.inicialRobo1[4];
                Program.auxDirecao1 = Program.inicialRobo1[4];
                if (Program.inicialRobo1[1] != ' ' || Program.inicialRobo1[3] != ' ')
                {
                    Console.WriteLine("Apenas espaços para separar os valores (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (!int.TryParse(Program.auxPosicaoX1.ToString(), out Program.posicaoX1) || !int.TryParse(Program.auxPosicaoY1.ToString(), out Program.posicaoY1))
                {
                    Console.WriteLine("Número inválido, tente novamente (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.Direcao1 != 'N' && Program.Direcao1 != 'S' && Program.Direcao1 != 'L' && Program.Direcao1 != 'O')
                {
                    Console.Write("O último valor deve ser uma letra indicando pontos cardeais (N - Norte, L - Leste, S - Sul, O - Oeste)");
                    Console.Write("\n Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.posicaoX1 < 0 || Program.posicaoY1 < 0)
                {
                    Console.Write("Por favor, não use números negativos (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.posicaoX1 > Convert.ToInt32(Program.coordenadaMaxX) || Program.posicaoY1 > Convert.ToInt32(Program.coordenadaMaxY))
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
                Program.inicialRobo2 = Console.ReadLine()!.ToUpper().Trim();

                Program.auxPosicaoY2 = Program.inicialRobo2[2];
                Program.auxPosicaoX2 = Program.inicialRobo2[0];
                Program.Direcao2 = Program.inicialRobo2[4];
                Program.auxDirecao2 = Program.inicialRobo2[4];

                if (Program.inicialRobo2[1] != ' ' || Program.inicialRobo2[3] != ' ')
                {
                    Console.WriteLine("Apenas espaços para separar os valores (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (!int.TryParse(Program.auxPosicaoX2.ToString(), out Program.posicaoX2) || !int.TryParse(Program.auxPosicaoY2.ToString(), out Program.posicaoY2))
                {
                    Console.WriteLine("Número inválido, tente novamente (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.posicaoX2 < 0 || Program.posicaoY2 < 0)
                {
                    Console.Write("Por favor, não use números negativos (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.posicaoX2 > Convert.ToInt32(Program.coordenadaMaxX) || Program.posicaoY2 > Convert.ToInt32(Program.coordenadaMaxY))
                {
                    Console.Write("Os números informados são maiores que o valor do grid (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.posicaoX2 == Program.posicaoX1 && Program.posicaoY2 == Program.posicaoY1)
                {
                    Console.Write("Os dois robôs não podem ocupar o mesmo espaço. (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }
                else if (Program.Direcao2 != 'N' && Program.Direcao2 != 'S' && Program.Direcao2 != 'L' && Program.Direcao2 != 'O')
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
                Console.Write($"Posição atual: X:{Program.posicaoX1} Y:{Program.posicaoY1} Direção:{Program.Direcao1}\n");
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
                        if (Program.N1 == true)
                        {
                            Program.N1 = false;
                            Program.O1 = true;
                            Program.Direcao1 = 'O';
                        }
                        else if (Program.O1 == true)
                        {
                            Program.O1 = false;
                            Program.S1 = true;
                            Program.Direcao1 = 'S';
                        }
                        else if (Program.S1 == true)
                        {
                            Program.S1 = false;
                            Program.L1 = true;
                            Program.Direcao1 = 'L';
                        }
                        else if (Program.L1 == true)
                        {
                            Program.L1 = false;
                            Program.N1 = true;
                            Program.Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (Program.N1 == true)
                        {
                            Program.N1 = false;
                            Program.L1 = true;
                            Program.Direcao1 = 'L';
                        }
                        else if (Program.L1 == true)
                        {
                            Program.L1 = false;
                            Program.S1 = true;
                            Program.Direcao1 = 'S';
                        }
                        else if (Program.S1 == true)
                        {
                            Program.S1 = false;
                            Program.O1 = true;
                            Program.Direcao1 = 'O';
                        }
                        else if (Program.O1 == true)
                        {
                            Program.O1 = false;
                            Program.N1 = true;
                            Program.Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (Program.N1 == true)
                            Program.posicaoY1 = Program.posicaoY1 + 1;
                        if (Program.L1 == true)
                            Program.posicaoX1 = Program.posicaoX1 + 1;
                        if (Program.S1 == true)
                            Program.posicaoY1 = Program.posicaoY1 - 1;
                        if (Program.O1 == true)
                            Program.posicaoX1 = Program.posicaoX1 - 1;
                    }

                }
                if (Program.posicaoX1 < 0 || Program.posicaoY1 < 0 || Program.posicaoX1 > Convert.ToInt32(Program.coordenadaMaxX) || Program.posicaoY1 > Convert.ToInt32(Program.coordenadaMaxY))
                {
                    Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                    Program.posicaoX1 = Convert.ToInt32(Program.auxPosicaoX1.ToString());
                    Program.posicaoY1 = Convert.ToInt32(Program.auxPosicaoY1.ToString());
                    Program.Direcao1 = Program.auxDirecao1;
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
                Console.Write($"Posição atual: X:{Program.posicaoX2} Y:{Program.posicaoY2} Direção:{Program.Direcao2}\n");
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
                        if (Program.N2 == true)
                        {
                            Program.N2 = false;
                            Program.O2 = true;
                            Program.Direcao2 = 'O';
                        }
                        else if (Program.O2 == true)
                        {
                            Program.O2 = false;
                            Program.S2 = true;
                            Program.Direcao2 = 'S';
                        }
                        else if (Program.S2 == true)
                        {
                            Program.S2 = false;
                            Program.L2 = true;
                            Program.Direcao2 = 'L';
                        }
                        else if (Program.L2 == true)
                        {
                            Program.L2 = false;
                            Program.N2 = true;
                            Program.Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (Program.N2 == true)
                        {
                            Program.N2 = false;
                            Program.L2 = true;
                            Program.Direcao2 = 'L';
                        }
                        else if (Program.L2 == true)
                        {
                            Program.L2 = false;
                            Program.S2 = true;
                            Program.Direcao2 = 'S';
                        }
                        else if (Program.S2 == true)
                        {
                            Program.S2 = false;
                            Program.O2 = true;
                            Program.Direcao2 = 'O';
                        }
                        else if (Program.O2 == true)
                        {
                            Program.O2 = false;
                            Program.N2 = true;
                            Program.Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (Program.N2 == true)
                            Program.posicaoY2 = Program.posicaoY2 + 1;
                        if (Program.L2 == true)
                            Program.posicaoX2 = Program.posicaoX2 + 1;
                        if (Program.S2 == true)
                            Program.posicaoY2 = Program.posicaoY2 - 1;
                        if (Program.O2 == true)
                            Program.posicaoX2 = Program.posicaoX2 - 1;
                    }
                }
                if (Program.posicaoX2 < 0 || Program.posicaoY2 < 0 || Program.posicaoX2 > Convert.ToInt32(Program.coordenadaMaxX) || Program.posicaoY2 > Convert.ToInt32(Program.coordenadaMaxY))
                {
                    Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                    Program.posicaoX2 = Convert.ToInt32(Program.auxPosicaoX2.ToString());
                    Program.posicaoY2 = Convert.ToInt32(Program.auxPosicaoY2.ToString());
                    Program.Direcao2 = Program.auxDirecao2;
                    Program.prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                if (Program.posicaoX2 == Program.posicaoX1 && Program.posicaoY2 == Program.posicaoY1)
                {
                    Console.WriteLine("Assim os robôs vão bater po!!!!!");
                    Console.Write("Pressione ENTER para continuar");
                    Program.posicaoX2 = Convert.ToInt32(Program.auxPosicaoX2.ToString());
                    Program.posicaoY2 = Convert.ToInt32(Program.auxPosicaoY2.ToString());
                    Program.Direcao2 = Program.auxDirecao2;
                    Program.prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                Program.prosseguir = true;
            } while (Program.prosseguir == false);
        }
    }
}
