namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inicialRobo1, inicialRobo2;
            string coordenadaMaxX = default!;
            string coordenadaMaxY = default!;
            bool prosseguir = false;
            int posicaoX1 = default, posicaoX2 = default;
            int posicaoY1 = default, posicaoY2 = default;            
            bool N1 = false, L1 = false, S1 = false, O1 = false, N2 = false, L2 = false, S2 = false, O2 = false;
            char Direcao1, Direcao2, auxDirecao2 = ' ', auxPosicaoX2 = ' ', auxPosicaoY2 = ' ', auxDirecao1 = ' ', auxPosicaoX1 = ' ', auxPosicaoY1 = ' ';            
            //Grid
            do
            {
                Console.Clear();
                Cabecalho();
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
                        prosseguir = true;
                    }
                }
            } while (prosseguir == false);

            //Posição inicial do robô 1
            do
            {
                prosseguir = false;
                Console.Clear();
                Cabecalho();

                Console.Write("Informe a posição inicial e  do robô 1 (Exemplo.:1 3 N): ");
                inicialRobo1 = Console.ReadLine()!.ToUpper().Trim();

                auxPosicaoY1 = inicialRobo1[2];
                auxPosicaoX1 = inicialRobo1[0];
                Direcao1 = inicialRobo1[4];
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
                else if (Direcao1 != 'N' && Direcao1 != 'S' && Direcao1 != 'L' && Direcao1 != 'O')
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
                else if (posicaoX1 > Convert.ToInt32(coordenadaMaxX) || posicaoY1 > Convert.ToInt32(coordenadaMaxY))
                {
                    Console.Write("Os números informados são maiores que o valor do grid (Aperte ENTER para continuar)");
                    Console.ReadLine();
                    continue;
                }               
                prosseguir = true;
            } while (prosseguir == false);

            //Posição do robô 2
            do
            {
                prosseguir = false;
                Console.Clear();
                Cabecalho();

                Console.Write("Informe a posição inicial e  do robô 2 (Exemplo.:1 3 N): ");
                inicialRobo2 = Console.ReadLine()!.ToUpper().Trim();

                auxPosicaoY2 = inicialRobo2[2];
                auxPosicaoX2 = inicialRobo2[0];
                Direcao2 = inicialRobo2[4];
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
                else if (posicaoX2 > Convert.ToInt32(coordenadaMaxX) || posicaoY2 > Convert.ToInt32(coordenadaMaxY))
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
                else if (Direcao2 != 'N' && Direcao2 != 'S' && Direcao2 != 'L' && Direcao2 != 'O')
                {
                    Console.Write("O último valor deve ser uma letra indicando pontos cardeais (N - Norte, L - Leste, S - Sul, O - Oeste)");
                    Console.Write("\n Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }               
                prosseguir = true;
            } while (prosseguir == false);

            //Lógica cardeal
            if (Direcao1 == 'N')
            {
                N1 = true;
                S1 = false;
                L1 = false;
                O1 = false;
                
            }
            else if (Direcao1 == 'S')
            {
                N1 = false;
                S1 = true;
                L1 = false;
                O1 = false;
                
            }
            else if (Direcao1 == 'L')
            {         
                N1 = false;
                S1 = false;
                L1 = true;
                O1 = false;
            }
            else if (Direcao1 == 'O')
            {
                N1 = false;
                S1 = false;
                L1 = false;
                O1 = true;
            }
            //Lógica cardeal robô 2
            if (Direcao2 == 'N')
            {
                N2 = true;
                S2 = false;
                L2 = false;
                O2 = false;
            }
            else if (Direcao2 == 'S')
            {
                N2 = false;
                S2 = true;
                L2 = false;
                O2 = false;
            }
            else if (Direcao2 == 'L')
            {
                N2 = false;
                S2 = false;
                L2 = true;
                O2 = false;
            }
            else if (Direcao2 == 'O')
            {
                N2 = false;
                S2 = false;
                L2 = false;
                O2 = true;
            }

            //Movimentação do robô 1
            do
            {
                Console.Clear();
                Cabecalho();

                Console.Write("Movimentação do Robô 1 \n");
                Console.Write($"Posição atual: X:{posicaoX1} Y:{posicaoY1} Direção:{Direcao1}\n");
                Console.WriteLine("----------------------------------------------------------");

                Console.Write("Quantas ações irão ser executadas ?: ");
                if (!int.TryParse(Console.ReadLine(), out int totalAcoes))
                {
                    Console.WriteLine("Entrada inválida, tente novamente");
                    Console.Write("Pressione ENTER para continuar");
                    Console.ReadLine();
                    prosseguir = false;
                    continue;
                }

                Console.Write("\nInforme toda a movimentação do robô 1(E - 90º Esquerda | D - 90º Direita | M - Mover para frente): ");
                string movimentacoes = Console.ReadLine()!.ToUpper().Trim();

                for (int i = 0; i < totalAcoes; i++)
                {
                    if (movimentacoes[i] == 'E')
                    {
                        if (N1 == true)
                        {
                            N1 = false;
                            O1 = true;
                            Direcao1 = 'O';
                        }
                        else if (O1 == true)
                        {
                            O1 = false;
                            S1 = true;
                            Direcao1 = 'S';
                        }
                        else if (S1 == true)
                        {
                            S1 = false;
                            L1 = true;
                            Direcao1 = 'L';
                        }
                        else if (L1 == true)
                        {
                            L1 = false;
                            N1 = true;
                            Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (N1 == true)
                        {
                            N1 = false;
                            L1 = true;
                            Direcao1 = 'L';
                        }
                        else if (L1 == true)
                        {
                            L1 = false;
                            S1 = true;
                            Direcao1 = 'S';
                        }
                        else if (S1 == true)
                        {
                            S1 = false;
                            O1 = true;
                            Direcao1 = 'O';
                        }
                        else if (O1 == true)
                        {
                            O1 = false;
                            N1 = true;
                            Direcao1 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (N1 == true)
                            posicaoY1 = posicaoY1 + 1;
                        if (L1 == true)
                            posicaoX1 = posicaoX1 + 1;
                        if (S1 == true)
                            posicaoY1 = posicaoY1 - 1;
                        if (O1 == true)
                            posicaoX1 = posicaoX1 - 1;
                    }

                }
                if (posicaoX1 < 0 || posicaoY1 < 0 || posicaoX1 > Convert.ToInt32(coordenadaMaxX) || posicaoY1 > Convert.ToInt32(coordenadaMaxY))
                {
                    Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                    posicaoX1 = Convert.ToInt32(auxPosicaoX1.ToString());
                    posicaoY1 = Convert.ToInt32(auxPosicaoY1.ToString());
                    Direcao1 = auxDirecao1;
                    prosseguir = false;
                    Console.ReadLine();
                    continue;
                }
                prosseguir = true;
            } while (prosseguir == false);

            do
            {
                //Movimentação do robô 2
                Console.Clear();
                Cabecalho();

                Console.Write("Movimentação do Robô 2 \n");
                Console.Write($"Posição atual: X:{posicaoX2} Y:{posicaoY2} Direção:{Direcao2}\n");
                Console.WriteLine("----------------------------------------------------------");

                Console.Write("Quantas ações irão ser executadas ?: ");               
                if (!int.TryParse(Console.ReadLine(), out int totalAcoes))
                {
                    Console.WriteLine("Entrada inválida, tente novamente");
                    Console.Write("Pressione ENTER para continuar");
                    Console.ReadLine();
                    prosseguir = false;
                    continue;
                }

                Console.Write("\nInforme toda a movimentação do robô 2 (E - 90º Esquerda | D - 90º Direita | M - Mover para frente): ");
                string movimentacoes = Console.ReadLine()!.ToUpper().Trim();

                for (int i = 0; i < totalAcoes; i++)
                {
                    if (movimentacoes[i] == 'E')
                    {
                        if (N2 == true)
                        {
                            N2 = false;
                            O2 = true;
                            Direcao2 = 'O';
                        }
                        else if (O2 == true)
                        {
                            O2 = false;
                            S2 = true;
                            Direcao2 = 'S';
                        }
                        else if (S2 == true)
                        {
                            S2 = false;
                            L2 = true;
                            Direcao2 = 'L';
                        }
                        else if (L2 == true)
                        {
                            L2 = false;
                            N2 = true;
                            Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'D')
                    {
                        if (N2 == true)
                        {
                            N2 = false;
                            L2 = true;
                            Direcao2 = 'L';
                        }
                        else if (L2 == true)
                        {
                            L2 = false;
                            S2 = true;
                            Direcao2 = 'S';
                        }
                        else if (S2 == true)
                        {
                            S2 = false;
                            O2 = true;
                            Direcao2 = 'O';
                        }
                        else if (O2 == true)
                        {
                            O2 = false;
                            N2 = true;
                            Direcao2 = 'N';
                        }
                    }
                    if (movimentacoes[i] == 'M')
                    {
                        if (N2 == true)
                            posicaoY2 = posicaoY2 + 1;
                        if (L2 == true)
                            posicaoX2 = posicaoX2 + 1;
                        if (S2 == true)
                            posicaoY2 = posicaoY2 - 1;
                        if (O2 == true)
                            posicaoX2 = posicaoX2 - 1;
                    }
                }
                    if (posicaoX2 < 0 || posicaoY2 < 0 || posicaoX2 > Convert.ToInt32(coordenadaMaxX) || posicaoY2 > Convert.ToInt32(coordenadaMaxY))
                    {
                        Console.Write("Robô irá sair do grid desse jeito. (Pressione ENTER para tentar novamente)");
                        posicaoX2 = Convert.ToInt32(auxPosicaoX2.ToString());
                        posicaoY2 = Convert.ToInt32(auxPosicaoY2.ToString());
                        Direcao2 = auxDirecao2;
                        prosseguir = false;
                        Console.ReadLine();
                        continue;
                    }
                    if (posicaoX2 == posicaoX1 && posicaoY2 == posicaoY1)
                    {
                        Console.WriteLine("Assim os robôs vão bater po!!!!!");
                        Console.Write("Pressione ENTER para continuar");
                        posicaoX2 = Convert.ToInt32(auxPosicaoX2.ToString());
                        posicaoY2 = Convert.ToInt32(auxPosicaoY2.ToString());
                        Direcao2 = auxDirecao2;
                        prosseguir = false;
                        Console.ReadLine();
                        continue;
                    }
                prosseguir = true;
            } while (prosseguir == false);
            Console.Write($"\nPosição nova do robô 1: {posicaoX1} {posicaoY1} {Direcao1}");
            Console.Write($"\nPosição nova do robô 2: {posicaoX2} {posicaoY2} {Direcao2}");
        }       
        public static void Cabecalho()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("     Robôs Tupiniquins     ");
            Console.WriteLine("===========================");
        }      
    }
}
            
            
            
    


