namespace RoboTupiniquim.ConsoleApp
{
    internal class Cardeais
    {
        public static bool N1 = false, L1 = false, S1 = false, O1 = false, N2 = false, L2 = false, S2 = false, O2 = false;
        public static char Direcao1, Direcao2;
        public static void GerarCardeaisDoRobo1()
        {
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
        }
        public static void GerarCardeaisDoRobo2()
        {
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
        }
    }
}
