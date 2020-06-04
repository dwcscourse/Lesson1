using System;

namespace Lesson3
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
                return 1;
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            //NumberManipulator n = new NumberManipulator();
            //calling the factorial method {0}", n.factorial(6));
            //Console.WriteLine("Factorial of 7 is : {0}", n.factorial(3));
            //Console.WriteLine("Factorial of 8 is : {0}", n.factorial(4));


            Counter(4);
                                 
            Console.ReadLine();
        }

        public static void Counter(int number)
        {
            if(number == 0)
            {
                Console.WriteLine("Bottom of the recursion " + number);
                return;
            }
            Console.WriteLine("Start " + number);
            Counter(number - 1);
            Console.WriteLine("Finish " + number);
        }
        

    }
}
