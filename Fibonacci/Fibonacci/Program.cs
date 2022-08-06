using System;
//0 
namespace Fibonacci
{
    class Program
    {
       
        static void Main(string[] args)
            
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : "); //
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");//i will enter 2
            }
            else
            {
                //First print first and second number

                Console.Write(firstNumber + " " + SecondNumber + " "); // 0 1 

                //Starts the loop from 2 because 0 and 1 are already printed

                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber; // 1
                    Console.Write(nextNumber + " "); 
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            Console.ReadKey();
        }
    }
}
