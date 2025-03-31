namespace RoboTupiniquim.ConsoleApp
{
    internal class Cardeais
    {
        public static void GerarCardeaisDoRobo1()
        {
            if (Program.Direcao1 == 'N')
            {
                Program.N1 = true;
                Program.S1 = false;
                Program.L1 = false;
                Program.O1 = false;

            }
            else if (Program.Direcao1 == 'S')
            {
                Program.N1 = false;
                Program.S1 = true;
                Program.L1 = false;
                Program.O1 = false;

            }
            else if (Program.Direcao1 == 'L')
            {
                Program.N1 = false;
                Program.S1 = false;
                Program.L1 = true;
                Program.O1 = false;
            }
            else if (Program.Direcao1 == 'O')
            {
                Program.N1 = false;
                Program.S1 = false;
                Program.L1 = false;
                Program.O1 = true;
            }
        }
        public static void GerarCardeaisDoRobo2()
        {
            if (Program.Direcao2 == 'N')
            {
                Program.N2 = true;
                Program.S2 = false;
                Program.L2 = false;
                Program.O2 = false;
            }
            else if (Program.Direcao2 == 'S')
            {
                Program.N2 = false;
                Program.S2 = true;
                Program.L2 = false;
                Program.O2 = false;
            }
            else if (Program.Direcao2 == 'L')
            {
                Program.N2 = false;
                Program.S2 = false;
                Program.L2 = true;
                Program.O2 = false;
            }
            else if (Program.Direcao2 == 'O')
            {
                Program.N2 = false;
                Program.S2 = false;
                Program.L2 = false;
                Program.O2 = true;
            }
        }
    }
}
