using System;

namespace Day1_Lab2
{
    class Program
    {
        // === ROOM CALCULATOR =======
        static void Main(string[] args)
        {
            bool bContinue = false;
            do
            {
                // Get the length of the room 
                Console.WriteLine("Please enter length of the room");
                double length = double.Parse(Console.ReadLine());

                // Get the width of the room 
                Console.WriteLine("Please enter width of the room");
                double width = double.Parse(Console.ReadLine());

                // Get the height of the room 
                Console.WriteLine("Please enter height of the room");
                double height = double.Parse(Console.ReadLine());

                // Calculate area
                double area = length * width;

                // Calculate perimeter
                double perimeter = 2 * (length + width);

                // Calculate volume
                double volume = length * width * height;

                // Display area and perimeter
                Console.WriteLine("Area of your room is: " + area + " sq units");
                Console.WriteLine("Perimeter of your room is: " + perimeter + " units");
                Console.WriteLine("Volume of your room is: " + volume + " cu units");
                           
                // Check if the user wants to continue
                Console.WriteLine("Do you want to continue for other rooms? y/n");
                string option = Console.ReadLine();
                option = option.ToLower();
                
                if (option[0] == 'y')
                    bContinue = true;
                else if (option[0] == 'n')
                    bContinue = false;

            } while (bContinue == true);
        }
    }
}
