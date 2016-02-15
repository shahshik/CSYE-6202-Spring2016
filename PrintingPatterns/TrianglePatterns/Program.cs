using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            int i, j;
            i = 0;
            j = 0;

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        
       }

        static void DisplayPatternB()
        {

            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                     Console.Write("");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
               Console.ReadLine();
           
         }
    


		static void DisplayPatternC()
		{

            int i, j, k;
            for (i = 10; i >= 1; i--)
            {
                for (j = 1; j <= 10 -i; j++)
                {
                   Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }

		static void DisplayPatternD()
		{
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
	}
}
