using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Grade Do You Expect To Get In ISM 4300...");
            /* Use the try catch block to validate user input.
             * If the user provides bad input, the catch block will handle the error and a message will be displayed.
             */
            try
            {

                // This variable will gather the user input
                string input = Console.ReadLine();

                /*  This variable will be used to store grade values
                 *  after the input variable is parsed to decimal
                 */
                decimal numerical_grade = decimal.Parse(input);

                // This variable will be used to get the number of years user has been in sales

                int letter_grade = 0;

                /*   This IF/ELSE IF/ELSE statement is used to conditionally
                     test the users input. Various options are available
                     depending on the amount entered by the user. Then, insde of each IF/ELSE IF/ELSE
                     there is a switch conditional statement that displays a message depending
                     on the number of years experience in sales entered by the user. 
                    */

                if (numerical_grade > 97)
                {
                    Console.WriteLine("Your Grade Is An A+");
                    letter_grade = int.Parse(Console.ReadLine());
                }
                else if ((numerical_grade > 91) && (numerical_grade < 98))
                {
                    Console.WriteLine("Your Grade Is An A");
                }
                else if ((numerical_grade > 89) && (numerical_grade < 92))
                {
                    Console.WriteLine("Your Grade Is An A-");
                }

                else if ((numerical_grade > 87) && (numerical_grade < 90))
                {
                    Console.WriteLine("Your Grade Is A B+");
                }

                else if ((numerical_grade > 81) && (numerical_grade < 88))
                {
                    Console.WriteLine("Your Grade Is A B");

                }
                else if ((numerical_grade > 77) && (numerical_grade < 80))
                {
                    Console.WriteLine("Your Grade Is A C+");

                }
                else if ((numerical_grade > 71) && (numerical_grade < 78))
                {
                    Console.WriteLine("Your Grade Is A C");

                }
                else if ((numerical_grade > 69) && (numerical_grade < 72))
                { Console.WriteLine("Your Grade Is A C-"); 
                
                }
                else if ((numerical_grade > 67) && (numerical_grade < 70))
                {
                    Console.WriteLine("Your Grade Is A D+");
                }
                else if ((numerical_grade > 61) && (numerical_grade < 68))
                {
                    Console.WriteLine("Your Grade Is A D");
                }
                else if ((numerical_grade > 59) && (numerical_grade <= 61))
                {
                    Console.WriteLine("Your Grade Is A D-");
                }
                else if ((numerical_grade > 0) && (numerical_grade < 60))
                { 
                    Console.WriteLine("Your Grade Is A F");
                }
                    


            }
            catch { }
            }
            }
    }


