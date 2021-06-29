using System;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number;
           

            Console.WriteLine("Enter a Number: ");
            Number = Console.ReadLine();
            int result = Int32.Parse(Number);

            if(result % 2 != 0) {

                Console.WriteLine(result + " is odd");

            }
            else
            {
                Console.WriteLine(result + " is even");
            }
        }
    }
}
