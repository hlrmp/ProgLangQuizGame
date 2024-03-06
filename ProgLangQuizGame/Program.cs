

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
            {"1. What COBOL stands for? ",
                "a. Common Business Oriented Language     b. Clasified Business Oriented Language     c. Clear Business Object Language",
            },
            {"2. What LISP stands for?","a. Latest Processor     b. List Processor     c. Last Processor" ,
            },
            {"3. Where does word ALGOL Derived from? "," a. Algorithm Languagge      b. Algorithm Lesson      c. Algorithmic Language",
            },
            {"4. It is Based on C++ and Java but includes some ideas from Delphi and Visual Basic ","a. C      b. C#      c. CSS",
            },
            {"5. It is Derived from Augusta Ada Byron","a. Ada     b. Byron      c. Augusta"
            }


        };
        string[,] answers = new string[,]
        {
            {"a" 
           ,},
            {"b"
           ,},
            {"c"
           ,},
            {"b"
           ,},
            {"a"
            }


        };

        string[] status = new string[10];
        

        



        int a = 0; // total number of Questions
        int c = 0; // correct
        int w = 0; // wrong
        int retak = 0; // To retake
        int ret = 1;  // number of Rretake 
        bool retake = true;
        while(retake == true)
        {
            try
            {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("================================================================================");
                    Console.ResetColor();

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
                    Console.ResetColor();


                    Console.WriteLine(questions[a, 0]);

                    Console.WriteLine(questions[a, 1]);

                    string ans = Console.ReadLine();

                    status[a] = (ans);

                    if ((answers[a, 0]).Equals(status[a]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" ");
                        Console.WriteLine("Correct");
                        Console.WriteLine(" ");
                        Console.ResetColor();

                        c++;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.WriteLine("Wrong");
                        Console.WriteLine(" ");
                        Console.ResetColor();
                        w++;
                    }

                    a++;

                }
                while (a < 5);
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
                    Console.ResetColor();



                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("    Your Score: " + c + " / " + a + "          ");
                    Console.WriteLine("    # of takes: "+ret+ "              ");
                    Console.WriteLine("-------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("                               ");

                    a = a - a;
                    c = c - c;
                    w = w - w;
                    
                  
                    

                    //  Console.WriteLine(a);


                }

                Console.WriteLine("Finish press any key  , Retake press 1");
                retak = int.Parse(Console.ReadLine());
                
                if (retak <= 0 || retak >= 2)
                {
                    retake = false;


                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("                               ");
                    Console.WriteLine("             Finish            ");
                    Console.WriteLine("-------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("                               ");

                }
                else
                {
                    ret = ret + 1;

                }



            }
        
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("                               ");
                Console.WriteLine("             Finish            ");
                Console.WriteLine("-------------------------------");
                Console.ResetColor();
                Console.WriteLine("                               ");
                retake = false;

                
              
            }


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





