/* 
 * This program estimates the cost of painting a room based on length inputs.
 * 
 * User enters room length and width and the program calculates painting costs.
 * 
 * Program does not loop
 */

using System;
using static System.Console;

namespace EstimatePaintCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double paintEstimate;

            //Prompt the user for room length and width
            WriteLine("Please enter the room length in feet: ");
            length = Convert.ToDouble(ReadLine());

            WriteLine("Enter the room width in feet: ");
            width = Convert.ToDouble(ReadLine());

            //Call CalcPaintCost method, input arguments and display result
            paintEstimate = CalcPaintCost(length, width);
            WriteLine("The cost of painting this room is: $" + paintEstimate);
        }
        //Calculate painting cost method
        static double CalcPaintCost(double roomLength, double roomWidth)
        {
            const double PRICE_PER_SQUARE = 6;
            const double ROOM_HEIGHT = 9;
            double surfaceArea;
            double paintCost;

            surfaceArea = 2 * (roomLength * roomWidth + roomLength * ROOM_HEIGHT + roomWidth * ROOM_HEIGHT);
            paintCost = surfaceArea * PRICE_PER_SQUARE;
            return paintCost;
        }
    }
}
