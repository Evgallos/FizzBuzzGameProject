using System;
using System.ComponentModel.Design;
using static System.Console; //always we add this using static System.Console


namespace FizzBuzzGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fizz Buzz Game Original see bellow (unmarked from comment to run it)

            int value = 0;
            Write("Let's play Fizz Buzz\n ");
            Write("Enter a Number: \n");
            value = int.Parse(Console.ReadLine());

            if ((value % 3 == 0) && (value % 5 == 0)) //<< we put twice (()) for true false  assign
            {
                WriteLine($"{value} Fizz Buzz!\n ");
            }
            else if (value % 3 == 0)
            {
                WriteLine($"{value} Fizz \n");
            }
            else if  (value % 5 == 0)
            {
                WriteLine($"{value} Buzz!\n");
            }
            
            else
            {
                WriteLine(value);
            }
            */

            // Fizzy Buzz Game with improvments changes original is above and bellow with changes 
            //best way to write like that more proffesional see bellow:

            int value = 0;
            Write("Let's play Fizz Buzz\n ");
            Write("Enter a Number: \n");
            value = int.Parse(Console.ReadLine());
            string message;

            if ((value % 3 == 0) && (value % 5 == 0)) //<< we put twice (()) for true false  assign
                message = "Fizz Buzz!\n ";
            else if (value % 3 == 0)
                message = " Fizz \n";
            else if (value % 5 == 0)
                message = "Buzz!\n";
            else
            {
                message = value.ToString(); //<<< we use ToString to change the value from int to string to put in our string Message.
            }

            WriteLine(message);
            
            ReadKey();
        }
    }
}
            /* Proxeiro:
            if((age > = 18) &&(AND), ||(OR) (AGE < = 65) &&, || (gender = = "female"))

            Nested IF << Nested means one inside other:
            if ( )
            {
            if ( )
            if ( )
            if ( )
            }

            Else
            {
            if( )
             {
              }
            {

 How to find numbers ages, leaps years and etc see bellow : Conditional Statements www.W3resource
          double num1
           num2
            if (num > num2)
            WriteLine("num1 is greater");
            else
            WL (num2 is greater")