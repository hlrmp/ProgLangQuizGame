

using System.Collections;
using System.Text.RegularExpressions;
using ProgLangQuizGame;

public class gameOne
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Hello, World!");
        int n = int.Parse(Console.ReadLine());
        int ans = 0;


        string[,]questions = new string[,]
        {
            {"1. It is an event that occurs during the execution of a program that disrupts the normal flow of instructions ? ",
                "a. Exception     b. Extends     c. Inheritance",}



        };
        string[] answers = new string []
        {

        };



        int a = 0;
        int c = 0; // correct
        int w = 0; // wrong

        do
        {
            Console.WriteLine(questions[a,0] + questions[a,1]);

        }
        while (a < 10);
        {

            Console.WriteLine("ans");

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



    public string Answer(string answer)
    {
        if (Regex.IsMatch(answer, exceptionClass.letters))
        {

            return answer;

        }

        else
        {
            throw new StringFormatException("please enter your First Name Correctly");
        }


    }
}


