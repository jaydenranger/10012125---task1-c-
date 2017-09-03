using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will check two numbers and see if one is bigger smaller or greater than the other");
            
            Console.WriteLine("enter a number for num1");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number for num2");
            var num2 = int.Parse(Console.ReadLine());

            if(num1<num2){

            Console.WriteLine("number2 is greater than number1 ");

            }else if(num1 == num2){
            Console.WriteLine("number1 and number2 are equal");

            }else{

                    Console.WriteLine("number 2 is less than number 1");

            }

        }
    }
}
