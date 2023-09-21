﻿internal class Areaoftenshapes
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Area of ten different shapes");

        double[] areas = new double[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Select the shape of choice{i + 1}:");
            Console.WriteLine("Square,Circle,Rectangle,Triangle,Cone,Hexagon,Cylinder,Kite,Cube,Octagon):");
            string shapes = Console.ReadLine();
            switch (shapes.ToLower())
            {
                case "square":
                    Console.Write("Length:");
                    double side = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedSquareArea(side);
                    break;

                case "circle":
                    Console.Write("radius:");
                    double radius = double.Parse(Console.ReadLine());
                    areas[i] = CalcultedCircleArea(radius);
                    break;

                case "rectangle":
                    Console.Write("Length:");
                    double Length = double.Parse(Console.ReadLine());
                    Console.Write("Width:");
                    double Width = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedRectangleArea(Length, Width);
                    break;

                case "triangle":
                    Console.Write("Base:");
                    double Base = double.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    double Height = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedTriangleArea(Base, Height);
                    break;

                case "cone":
                    Console.Write("Cone radius:");
                    double Coneradius = double.Parse(Console.ReadLine());
                    Console.Write("Cone height:");
                    double Coneheight = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedConearea(Coneradius, Coneheight);
                    break;

                case "hexagon":
                    Console.Write("Hexagon length:");
                    double Hlength = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedHexagonArea(Hlength);
                    break;

                case "cylinder":
                    Console.Write("Cylinder radius:");
                    double Cynradius = double.Parse(Console.ReadLine());
                    Console.Write("Cylinder height:");
                    double Cynheight = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedCylinderarea(Cynradius, Cynheight);
                    break;

                case "kite":
                    Console.Write("p Diagonal:");
                    double pDiagonal = double.Parse(Console.ReadLine());
                    Console.Write("q Diagonal:");
                    double qDiagonal = double.Parse(Console.ReadLine());
                    areas[i] = Calculatedkitearea(pDiagonal, qDiagonal);
                    break;

                case "cube":
                    Console.Write("Edge:");
                    double Edge = double.Parse(Console.ReadLine());
                    areas[i] = CalcultedCubeArea(Edge);
                    break;

                case "octagon":
                    Console.Write("Octagon length:");
                    double Olength = double.Parse(Console.ReadLine());
                    areas[i] = CalculatedOctagonArea(Olength);
                    break;

                default:
                    Console.Write("Invalid Shape");
                    i--;
                    break;

            }
        }
        for (int i = 0; i < areas.Length; i++)
        {
            Console.WriteLine($"The area of shape{i + 1} is:{areas[i]}");
        }

    }
        static double CalculatedSquareArea(double side) 
        {
         return side * side;
        }

     static double CalcultedCircleArea(double radius)
        { 
          return Math.PI *Math.Pow( radius,2 );
        }

     static double CalculatedRectangleArea(double Length, double Width)
        {
         return Length * Width;
        }

     static double CalculatedTriangleArea(double Base, double Height)
        {
            return 0.5 * Base * Height;
        }

     static double CalculatedConearea(double Coneradius, double Coneheight)
        {
            return Math.PI *Coneradius * (Coneradius + Math.Sqrt(Coneheight * Coneheight+ Coneradius*Coneradius));
        }

     static double CalculatedHexagonArea(double Hlength)
        {
            return 3 * Math.Sqrt(3) / 2 *(Hlength * Hlength);
        }

        static double CalculatedCylinderarea(double Cynradius,double Cynheight)
        {
            return 2 * Math.PI * Cynradius *Cynheight + 2 *Math.PI * (Cynradius*Cynradius);
        }

       static double Calculatedkitearea(double pDiagonal,double qDiagonal)
        {
            return pDiagonal * qDiagonal/ 2;
        }

        static double CalcultedCubeArea(double Edge)
        {
            return 6 *  (Edge * Edge);
        }
         
        static double CalculatedOctagonArea(double Olength)
        {
            return 2 * (1 + Math.Sqrt(2)* (Olength * Olength));
        }

       




    

}
//Console.WriteLine($"Select the shape of choice{i + 1}:");
//Console.WriteLine("1:Square");
//Console.WriteLine("2:Circle");
//Console.WriteLine("3:Rectangle");
//Console.WriteLine("4:Triangle");
//Console.WriteLine("5:Cone");
//Console.WriteLine("6:Hexagon");
//Console.WriteLine("7:Cylinder");
//Console.WriteLine("8:Kite");
//Console.WriteLine("9:Cube");
//Console.WriteLine("10:Octagon");
//Console.WriteLine("selectiom 1,2,3,4,5,6,7,8,9,10");
//int selection = Convert.ToInt32(Console.ReadLine());