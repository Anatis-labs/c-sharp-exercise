using System;

namespace exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write the program code that lets the user input the radius (as a double).
            Then calculate the area and volume of a circle respective sphere with the
            given radius. (area = 2 πr 2, volume = (𝟒 × 𝛑 ×𝐫𝟑)/𝟑). Output the result to
            the screen. 
            */


            Console.WriteLine("Please enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = (Math.PI * (radius*radius));
            Console.WriteLine("based on the radius you entered then the area is: "+area);

            double volume = ((4*Math.PI*(radius*radius*radius)/3));
            Console.WriteLine("The volume of the sphere with the radius u entered is: "+ volume);
        }
    }
}
