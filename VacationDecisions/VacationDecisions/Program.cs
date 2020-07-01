using System;

namespace VacationDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string vacationType = System.String.Empty;
            string travelSuggestion = System.String.Empty;
            string destination = System.String.Empty;
            int tempNum, loop = 0, groupSize = 1;

            Console.WriteLine("What kind of trip would you like to go on musical, tropical, adventurous?");

            while(loop==0)
            {
                vacationType = Console.ReadLine();
                if (vacationType == "musical")
                {
                    destination = "New Orleans";
                    break;
                }
                else if (vacationType == "tropical")
                {
                    destination = "a beach vacation in Mexico";
                    break;
                }
                else if (vacationType == "adventurous")
                {
                    destination = "whitewater rafting the Grand Canyon";
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Please enter acceptable trip option.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine();
                    continue;
                }
            }

           
            while(loop==0)
            {
                Console.WriteLine();
                Console.WriteLine("How many are in your group?");
                if (int.TryParse(Console.ReadLine(), out tempNum))
                {
                    groupSize = tempNum;
                    if(groupSize == 1 || groupSize == 2)
                    {
                        travelSuggestion = "first class flight";
                    }
                    else if(groupSize >= 3 && groupSize <= 5)
                    {
                        travelSuggestion = "helicopter";
                    }
                    else if(groupSize >= 6)
                    {
                        travelSuggestion = "charter flight";
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Please enter a valid number.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine();
                    continue;
                }
            }

            

            result = "Since you’re a group of " + groupSize + " going on a/an " + vacationType +
                " vacation you should take a " + travelSuggestion + " to " + destination + ".";
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadKey();
            



        }
    }
}
