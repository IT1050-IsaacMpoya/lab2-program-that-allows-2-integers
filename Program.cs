using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {/* Main method begins execution of c# app */
        static void Main(string[] args)
        {
         int number1;
         int number2;
         int answer;
         Console.Write ("enter first number");// prompt user to enter first number
         number1 = Convert.ToInt32(Console.ReadLine());
        
         Console.Write("enter second number");// Prompt user to enter second number 
         number2 = Convert.ToInt32(Console.ReadLine());

         answer = number1 * number2;// multiply 2 numbers entered by user

         Console.WriteLine("answer is {0}", answer); //display product 
         Console.ReadLine(); // displays the results 
         

        }
    }
}
