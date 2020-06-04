using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW1 Print 1 to 100, prime or not, even and odd
            //HW1 Print 1 to 100, prime or not, even and odd
            //{ 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97}

            Console.WriteLine("1 is odd");
            Console.WriteLine("2 is even and prime");

            for (int i = 3; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                    bool isPrime = true;
                    for (int j = 3; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            Console.WriteLine($"{i} is odd");
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine($"{i} is odd and prime");
                    }

                }

            }


            //for (int i = 3; i <= 100; i++)
            //{
            //    int isPrime = 0;
            //    for (int k = 2; k <= i; k++)
            //    {
            //        if (i % k == 0)
            //            isPrime++;

            //        if (isPrime == 2 && i % 2 == 0)
            //        {
            //            Console.WriteLine($"{i} is even"); break;
            //        }

            //        else if (isPrime == 2 && i % 2 != 0)
            //        {
            //            Console.WriteLine($"{i} is odd"); break;
            //        }

            //    }

            //   if (isPrime == 1 && i % 2 != 0)
            //    {
            //        Console.WriteLine($"{i} is odd and prime"); 
            //    }

            //    isPrime = 0;
            //}

            Console.ReadLine();
        }
    }
}
