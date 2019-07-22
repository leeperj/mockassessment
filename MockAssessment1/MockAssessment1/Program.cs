using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Would you like to subtract numbers? Y/N");
            string userInput1 = Console.ReadLine().ToLower();
            if (userInput1 == "y" || userInput1 == "yes")
            {
                Console.WriteLine("Please enter first number.");
                int userInput2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a second number.");
                int userInput3 = int.Parse(Console.ReadLine());


                Console.WriteLine($"{userInput2} - {userInput3} is {Subtract(userInput2, userInput3)}.");
                Console.ReadLine();

                return;

            }
            else if (userInput1 == "n" || userInput1 == "no")
            {
                Console.WriteLine("That's okay, would you like to find out if 2 numbers are the same? Y/N");
                string userinput1 = Console.ReadLine().ToLower();

                if (userinput1 == "y" || userInput1 == "yes")
                {
                    Console.WriteLine("Please enter first number.");
                    int userInput2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a second number.");
                    int userInput3 = int.Parse(Console.ReadLine());
                    IsTheSame(userInput2, userInput3);

                    return;
                }
                else if (userInput1 == "n" || userInput1 == "no")
                {
                    Console.WriteLine("No problem, Would you like me to tell you how big a building is? Y/N");
                    string userInput2 = Console.ReadLine().ToLower();
                    if (userInput2 == "y" || userInput2 == "yes")
                    {
                        Console.WriteLine("How many floors does this building have?");
                        int floors = int.Parse(Console.ReadLine());
                        FindBuildingType(floors);
                        Console.ReadLine();
                        return;
                    }
                    else if (userInput2 == "n" || userInput2 == "no")
                    {
                        Console.WriteLine("Thats all I have for you today, press any key to exit.");
                        Console.ReadLine();
                    }
                }
                else
                    Console.WriteLine("Does not compute");

            }
            else

                Console.WriteLine("Does not compute");

       


        }



        public static bool IsTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine("These numbers are the same");
                Console.ReadLine();
                return true;

            }
            else
            {
                Console.WriteLine("These numbers are not the same");
                Console.ReadLine();
                return false;
            }

        }

        public static double Subtract(double num1, double num2)
        {
            double difference = num1 - num2;

            return difference;
        }

        
        public static void FindBuildingType(int num1)
        {
            if (num1 <= 3)
            {
                Console.WriteLine("This is a house!");
                Console.ReadLine();
                return;
            }
            else if (num1 >= 4 && num1 <= 10)
            {
                Console.WriteLine("This is an office building!");
                Console.ReadLine();
                return;
                
            }
            else if (num1 >= 11 && num1 < 50)
            {
                Console.WriteLine("This is a skyscraper!");
                Console.ReadLine();
                return;
            }
            else if(num1 > 50)
            {
                Console.WriteLine("This is a SUPER skyscraper!");
                Console.ReadLine();
                return;
            }
                   
                    

            
            
        }

    }



}
