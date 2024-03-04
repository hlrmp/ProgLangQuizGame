

using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using ProgLangQuizGame;

public class gameOne
{
    public static void Main(string[]args)
    {
     


        string[,]questions = new string[,]
        {
            {"1. It is an event that occurs during the execution of a program that disrupts the normal flow of instructions ? ",
                "a. Exception     b. Extends     c. Inheritance",
            }

        };
        string[,] answers = new string [,]
        {
            {"a","b"}
        };

        string[] status = new string[10];
        

        



        int a = 0; // total number of Questions
        int c = 0; // correct
        int w = 0; // wrong

        

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________");
            Console.ResetColor();

            Console.WriteLine(questions[a, 0] + questions[a, 1]);
            string ans = Console.ReadLine();

            status[a] = (ans);

            if ((answers[0,a]).Equals(status[a]))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();

                c++;

            }
            else
            {
                Console.WriteLine("Wrong");

                w++;
            }

            a++;

        }
        while (a < 1);
        {

            Console.Write("\u001b[1m");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("    Your Score: " + c + " / " +a + "          ");
            Console.WriteLine("-------------------------------");
            Console.ResetColor();
            //  Console.WriteLine(a);


        }


        try
        {
          
           

        }
        catch (NumberFormat e)
        {
            Console.WriteLine("Number Format Exception " + e.Message);
        }

       


       


    }


    exceptionClass ec = new exceptionClass(); // exceptionClass Instance


    class nullExceptiom : Exception
    {
        public nullExceptiom(string str) : base(str) { }
    }
    class StringFormatException : Exception
    {
        public StringFormatException(string str) : base(str) { }
    }
    class NumberFormat : Exception
    {
        public NumberFormat(string str) : base(str) { }
    }



}





