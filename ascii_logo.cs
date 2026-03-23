using System;
using System.Security.Policy;
using System.Drawing; 

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class ascii_logo
    {//start of class
        public ascii_logo()
        {//start of constructor

            //calling the ascii method to display the logo
            ascii();

        }//end of constructor

        //ascii method
        private void ascii()
        {//start of method

            //variable to store the path of the logo file
            string path = string.Empty;

            //getting the base directory of the application
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;

            //replacing the path to get the full path of the logo file
            path = fullpath.Replace(@"bin\Debug\", "logo.jpeg");

            Bitmap image = new Bitmap(path);

            // Resizing for better console fit
            int width = 60;
            int height = 30;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Setting console color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // ASCII characters
            string asciiChars = "@#S%?*+;:,.";

            // Loop through each pixel in the resized image
            for (int y = 0; y < resized.Height; y++)
            {//start of outer for loop

                //loop through each pixel in the row
                for (int x = 0; x < resized.Width; x++)
                {//start of inner for loop

                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);

                }//end of inner for loop

                Console.WriteLine();

            }//end of outer for loop

        }//end of method

    }//end of class

}//end of namespace