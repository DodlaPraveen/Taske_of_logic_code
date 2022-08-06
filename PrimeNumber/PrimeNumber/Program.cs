using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, x = 0, f = 0;
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine()); 
            x = num / 2;
            for (i = 2; i <= x; i++) 
            {
                if (num % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    f = 1;
                    break;
                }
            }
            if (f == 0)
                Console.Write("Number is Prime.");
        }
    }
}

//A Prime number is a number that can be divided either by itself or 1
//2 prime  1 and 2   ex: 2*1=2 ,1*2=2
//4 not prime 1,2,4  ex  1*4=4 , 2*2=4 , 4*1=4