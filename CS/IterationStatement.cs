using System;
using System.Diagnostics;

namespace SelectandLoop
{
    class IterationStatement
    {
        static void Main4()
        {
            IterationStatement interationstatement = new IterationStatement();
            interationstatement.LearnForLoops();
        }
        void LearnForLoops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }

            byte[] personAges = { 11, 21, 43, 55, 34 };

            foreach (byte age in personAges)
            {
                if (age % 2 == 0)
                {
                    Console.WriteLine(age + "is EVEN");
                }
                else
                {
                    Console.WriteLine(age + "is ODD");
                }
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        //     void LearnForLoops()
        //     {
        //         char confirm = 'Y';
        //         while(confirm == 'Y');
        //         {
        //             Console.WriteLine("I am inside while loop.");
        //             Console.WriteLine("Enter Y to continue:");
        //             confirm = Console.ReadKey().KeyChar; // confirm = console.Readline();
        //         }

        //         do
        //         {
        //             Console.WriteLine("I am inside while loop.");
        //             Console.WriteLine("Enter Y to continue:");
        //             confirm = Console.ReadKey().KeyChar;
        //         }
        //     }
    }
}