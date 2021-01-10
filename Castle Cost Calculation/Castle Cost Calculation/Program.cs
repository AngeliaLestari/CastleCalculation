using System;
using System.Data;
using System.Xml.Schema;

namespace Castle_Cost_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Castle do you like to build?");
            Console.Write("1:Great Castle, 2:Medium Castle, 3: Small Castle: ");
            string castle =Console.ReadLine();

            int cost = 180;
          
            switch (castle)
            {
                case "1":
                    double totalareaGC = Math.Round(circles(375) + rectangle(1500, 2500) + triangle(500, 750));
                    double totalcostGC = totalareaGC * cost;
                    Console.WriteLine($"Total Cost for Great Castle is {totalcostGC}");
                    break;

                case "2":
                    double totalcostMC = (circles(400) + rectangle(1000, 500)) * cost;
                    Console.WriteLine($"Total Cost for Medium Castle is {totalcostMC}");
                    break;

                case "3":
                    double totalcostSC = triangle(700, 70);
                    Console.WriteLine($"Total Cost for Small Castle is {totalcostSC}");
                    break;

                default:
                    Console.WriteLine("Castle That You asking is Not Available");
                    break;
            }
               
            
            
        }

        
        static double rectangle(double length, double width)
        {
            return length * width;
        }

        static double circles(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }





    }
}
