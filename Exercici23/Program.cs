using System;

namespace Exercici23
{
    public static class Exercici23
    {
        public static void Main()
        {
            const string MsgProgram = "De que vols calcular l'area:";
            const string MsgRectangle = "1. Rectangle";
            const string MsgQuadrat = "2. Quadrat";
            const string MsgCercle = "3. Cercle";
            const string MsgPentagon = "4. Pentagon";

            int options;
            Console.WriteLine(MsgProgram);
            Console.WriteLine(MsgRectangle);
            Console.WriteLine(MsgQuadrat);
            Console.WriteLine(MsgCercle);
            Console.WriteLine(MsgPentagon);
            options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:
                    int rectanglebase, alturarectangle;
                    Console.WriteLine("Introdueix la base del rectangle");
                    rectanglebase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix la altura del rectangle");
                    alturarectangle = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("L'area del rectangle es: " + CalcAreaRectangle(rectanglebase, alturarectangle));
                    break;
                case 2:
                    int costatquadrat;
                    Console.WriteLine("Introdueix el costat del quadrat");
                    costatquadrat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("L'area del quadrat es: " + CalcAreaQuadrat(costatquadrat));
                    break;
                case 3:
                    int radicercle;
                    Console.WriteLine("Introdueix el radi del cercle");
                    radicercle = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("L'area del cercle es: " + CalcAreaCercle(radicercle));
                    break;
                case 4:
                    int costatpentagon, apotemapentagon;
                    Console.WriteLine("Introdueix el costat del pentagon");
                    costatpentagon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix l'apotema del pentagon");
                    apotemapentagon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("L'area del pentagon es: " + CalcAreaPentagon(costatpentagon, apotemapentagon));
                    break;
                default:
                    Console.WriteLine("Error, valor incorrecte");
                    break;
            }
        }

        public static int CalcAreaQuadrat(int costat)
        {
            return costat * costat;
        }
        public static int CalcAreaRectangle(int rectanglebase, int altura)
        {
            return rectanglebase * altura;
        }
        public static double CalcAreaCercle(int radi)
        {
            return Math.PI * radi * radi;
        }
        public static int CalcAreaPentagon(int costat, int apotema)
        {
            return 5 * costat * apotema / 2;
        }
    }
}
