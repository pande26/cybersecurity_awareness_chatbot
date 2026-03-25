using System;
using System.Collections.Specialized;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class welcome_username
    {//start of class

        //global variable to store the username
        private string username = string.Empty;

        //void method to welcome the user
        public void welcome()
        {//start of method

            //message to welcome the user
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 Welcome to Valarie Chatbot                ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");

            //reset color
            Console.ResetColor();

        }//end of method

        //method to ask for the username
        public void ask_username()
        {//start of method

            //asking the user for their name
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("VALARIE: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Enter your name..");

            //reset color
            Console.ResetColor();

            //do-while loop to re-prompt the user until they enter a valid name
            do
            {//start of do-while loop

                //prompt and test color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("User: ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                username = Console.ReadLine();

            } while (!empty());//end of do while

        }//end of method

        //Boolean method to check the username in not empty
        public Boolean empty()
        {// start fo empty() method

            //checking if username is not empty using if statement
            if (username != "")
            {//start of if statement

                //susccess message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("VALARIE: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey, " + username);

                //reset color
                Console.ResetColor();

                //return true
                return true;

            }//end of if statement
            else
            {//start of else statement

                //error message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("VALARIE: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter name...");

                //return false
                return false;

            }//end of else statement

        }//end of empty() method

    }//end of class

}//end of namespace