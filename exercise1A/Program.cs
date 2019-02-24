using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1A
{
    public class Program
    {

        static void Main(string[] args)
        
        {

            Program convertedString = new Program();
            
            Console.WriteLine("This program will calculate the Area " +
                "\nand Circumference of a circle with Radius x." +
                "\nPlease input a positive numeric value for the Radius.");

            double rad = new double();

            while (true)
            {

                string y = Console.ReadLine();

                double.TryParse(y, out rad);

                if (rad <= 0)
                {
                    Console.WriteLine("Please enter a valid numerical value");

                }
                else
                {
                    double circ = Area_Circ(rad);
                    double area = Area_Circ(rad);
                    Console.WriteLine($"The area = {area} and the circumference = {circ}");
                    break;
                }
            }





            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();

            ///---------Start Volume Of Hemisphere-------------------------------------------------------------------------------------------------------///

            Console.WriteLine("This program will calculate the volume of a " +
                              "\nhemisphere with radius x. Please enter a " +
                              "\npositive numerical value for the radius.");


            Console.WriteLine($"The volume = {VolumeOfHemisphere(Console.ReadLine())}");


            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();

            ///---------Start Area Of Triangle-------------------------------------------------------------------------------------------------------///

            Console.WriteLine("This program will calculate the area of a " +
                              "\ntriange with sides a, b, and c. ");


            Console.WriteLine("Please input a value for a.");
            int a = ConvertNumber(Console.ReadLine());
            Console.WriteLine("Please input a value for b.");
            int b = ConvertNumber(Console.ReadLine());
            Console.WriteLine("Please input a value for c.");
            int c = ConvertNumber(Console.ReadLine());

            int p = HeronFormula(a, b, c);

            Console.WriteLine($"The Area of triangle is {AreaOfTriangle(p, a, b, c)}");

            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();

            ///-----------Start Quadratic Equation------------------------------------------------------------------------------------------------------------------------------/// 
            
            Console.WriteLine("This program will solva a quadratic equation " +
                              "\nwith 3 non-negative coefficients a,b,and c. " +
                              "\nThis equation will take the form ax^2 + bx + c = 0");

            while (true)
            {

                Console.WriteLine("Please input a value for a.");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Please input a value for b.");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Please input a value for c.");
                double f = double.Parse(Console.ReadLine());

                double testImaginary = NoImagination(d, e, f);

                if (testImaginary < 0)
                {
                    Console.WriteLine("Unfortunately, we are not allowing the use of imaginary numbers. " +
                                 "\nAn imgainary number will result if we take the square root of a " +
                                 "\nnegative number This means that b^2 - 4(a)(c) must not evaluate " +
                                 "\nto a negative number. Please enter new values, ensuring that " +
                                 "\nthe value of b is large enough to meet this requirement");

                }
                else
                {
                    Console.WriteLine($"The value of x is either {PosQuadraticEquation(d, e, f)}" +
                                      $" or {NegQuadraticEquation(d, e, f)}");
                    break;
                }
            }
        }


        //New Method No Imaginary 
        public static double NoImagination(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }


        //New Method Pos Quad
        public static double PosQuadraticEquation(double a, double b, double c)
        {
            return Convert.ToDouble(-b / (2 * a) + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }

        //New Mathod  Neg Quad
        public static double NegQuadraticEquation(double a, double b, double c)
        {
            return Convert.ToDouble(-b / (2 * a) - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }



        //New Method Convert Number
        public static int ConvertNumber(string input)
        {
            int side = new int();
            while (true)
            {

                int.TryParse(input, out side);

                if (side <= 0)
                {
                    Console.WriteLine("Please enter a valid numerical value");
                    input = Console.ReadLine();
                }
                else
                {
                    return side;
                }
            }

        }

        //New Method Heron 
        public static int HeronFormula(int a, int b, int c)
        {
            return (a + b + c) / 2;
        }

        //New Method Area of Triangle
        public static int AreaOfTriangle(int p, int a, int b, int c)
        {
            return Convert.ToInt32(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        //New Method Volume
        public static double VolumeOfHemisphere(string x)
        {
            double rad = new double();

            while (true)
            {

                double.TryParse(x, out rad);

                if (rad <= 0)
                {
                    Console.WriteLine("Please enter a valid numerical value");
                    x = Console.ReadLine();

                }
                else
                {
                    return (4.0 / 3 * Math.PI * Math.Pow(rad, 3)) / 2;
                }

            }
        }

        //New Method Area
        public static double Area_Circ(double rad)
        {

            return (Math.PI) * Math.Pow(rad, 2);
        }

        //New Method Circumference
        public static double Circ_Circ(double rad)
        {

            return 2 * (Math.PI) * rad;

        }

    }
}





