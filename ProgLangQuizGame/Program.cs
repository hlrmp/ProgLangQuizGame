

using System.Text.RegularExpressions;
using ProgLangQuizGame;

public class gameOne
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Hello, World!");
        string n = Console.ReadLine();

        Console.WriteLine(n);
        try
        {
            if (string.IsNullOrEmpty(n))
            {

            }
            else
            {
               
            }


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


