using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating an instance of voice_greeting class with constructor
            new voice_greeting() { };

            //creating an instance of ascii_logo class with constructor
            new ascii_logo();

            /*creating an instance of the welcome_username class
             * with an object name welcome_and_collect*/
            welcome_username welcome_and_collect = new welcome_username();

            welcome_and_collect.welcome();

            welcome_and_collect.ask_username();

        }//end of main method

    }//end of class

}//end of namespace
