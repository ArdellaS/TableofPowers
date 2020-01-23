using System;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {

            int square;
            int cube;
            string answer;
            int a;

            Console.WriteLine("Learn your squares and cubes!\n");
            Console.WriteLine("Please enter a number: ");
            do
            {
                bool checkNum = int.TryParse(Console.ReadLine(), out a);

                do
                {
                    if ((a <= 1290) && (a > 0))
                    {

                        Console.WriteLine($"Number\t\tSquared\t\tCubed");

                        for (int i = 0; i < a; i++)
                        {

                            square = (int)Math.Pow(i + 1, 2);
                            cube = (int)Math.Pow(i + 1, 3);

                            Console.WriteLine($"{i + 1,6}\t\t{square,6}\t\t{cube,6}");

                        }

                    }
                    else if (a > 1290)
                    {
                        Console.WriteLine("Number too high.\n");
                        Console.Write("Please enter a lower number: ");
                        checkNum = int.TryParse(Console.ReadLine(), out a);
                        continue;

                    }
                    else
                    {
                        Console.Write("Number too low.\n");
                        Console.Write("Please enter a lower number: ");
                        checkNum = int.TryParse(Console.ReadLine(), out a);
                        continue;
                    }

                } while (!checkNum);

                Console.WriteLine($"\nWant to try another number? yes/no");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer.Equals("yes") || answer.Equals("y"));

            Console.WriteLine("Hope you learn more later. Bye!");

        }


    }
}


