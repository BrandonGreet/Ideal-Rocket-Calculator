/* Brandon Greet
 * 9/6/17
 * This Program is designed to solve for inital mass according 
 * to the Tsiolkovsky Rocket Equation.
 */

using System;
using System.Diagnostics.Contracts;

namespace TsiolkovskyBot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Double deltaVelocity;
            Double dryMass;
            Double exhaustVelocity;

            //Introductions and questions for user
            Console.WriteLine("Hello, I'm TsiolkovskyBot\n");
            deltaVelocity = GetDouble("delta velocity (m/s)");
            dryMass = GetDouble("dry mass ");
            exhaustVelocity = GetDouble("exhaust velocity (m/s)");

            //Prints the result
            Console.WriteLine("\nThe inital mass of your proposed rocket is: ");
            Console.Write(dryMass * Math.Pow(Math.E, (deltaVelocity / exhaustVelocity)));
            Console.WriteLine(" kg");
        }

        //Just for neatness in the Main method
        private static Double GetDouble (String varName)
        {
            Double input = -1.0;
            bool isNotOK = true;
            while (isNotOK)
            {
                Console.Write("Please enter the value of " + varName + ": ");
                try
                {
                    input = Double.Parse(Console.ReadLine());
                    if (input > 0)
                    {
                        isNotOK = false;
                    }
                    else
                    {
                        Console.WriteLine("\nTry again. Think positive. :D\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e + "\n\nSee what you did? You need to " +
                                      "enter a double or you'll make C# cry again.\n");
                }
            }
            return input;
        }
    }
}
