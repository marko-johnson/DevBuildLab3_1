using System;

namespace Lab3_1
{
    class Program
    {
        static bool KeepGoing()
        {

            while (true)
            {

                // Print out message asking if user wants to continue

                Console.Write("\nWould you like to know about another student? (enter “yes” or “no): ");

                // Ask the user for their input

                string response = Console.ReadLine();
                response = response.ToLower();

                // Check if They typed "y". If so, return true.
                // Otherwise return false.

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3.1: Marko Johnson");
            Console.WriteLine("Hello from lab 3.1");

            do
            {

            
            string[] names = { "Tina", "Will", "Mario", "Marko", "Corinne" };
            string[] favCandy = { "Reese's peanut butter cups", "Snicker's chocolate bars", "PayDay candy bars", "Take 5 candy bar", "green lollipop" };
            string[] prevTitle = { "teacher", "laborer", "writer", "software engineer", "HR analyst" };

            int studentNumberChoice = 0;
            bool numOK = false;

            while (numOK == false)
            {

                Console.Write($"Which student would you like to learn more about? (enter a number 1-{names.Length}): ");
                string whichStudent = Console.ReadLine();

                if (int.TryParse(whichStudent, out studentNumberChoice))
                {
                    if (studentNumberChoice >= 1 && studentNumberChoice <= names.Length)
                    {
                        studentNumberChoice = studentNumberChoice - 1;
                        numOK = true;
                    }
                    else
                    {
                        Console.WriteLine($"That student does not exist. Please try again.");
                    }

                }
                
            }
            Console.WriteLine($"Student {studentNumberChoice + 1} is {names[studentNumberChoice]}. What would you like to know about {names[studentNumberChoice]}? (enter \"favorite candy\" or \"previous title\"): ");


            bool categoryOK = false;
            while (categoryOK == false)
            {
                string choice = Console.ReadLine();

                if (choice == "favorite candy")
                {
                    Console.WriteLine($"{names[studentNumberChoice]}'s favorite candy is {favCandy[studentNumberChoice]}.");
                    categoryOK = true;
                }
                else if (choice == "previous title")
                {
                    Console.WriteLine($"{names[studentNumberChoice]}'s previous title is {prevTitle[studentNumberChoice]}.");
                    categoryOK = true;
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter “favorite candy” or “previous title”):");
                }
                
            }
            }
            while (KeepGoing() == true) ;

            Console.WriteLine("\nThanks!");

        }
    }
}
