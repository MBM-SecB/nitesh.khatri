using System;

namespace SelectAndLoop
{
    class SelectionStatement
    {
        static void Main3()
        {
            SelectionStatement s = new SelectionStatement();
            s.CheckNumber();
        }

        void CheckNumber()
        {
            Console.Write("Enter the number:");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is EVEN.");
            }
            else
            {
                Console.WriteLine("The number is ODD.");
            }
        }


        void LearnSwitchStatements()
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "books":
                    Console.WriteLine("The Alchemist");
                    break;
                case "copies":
                    Console.WriteLine("Classmate");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}