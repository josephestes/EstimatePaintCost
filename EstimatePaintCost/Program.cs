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
            float length;
            float width;
            decimal paintEstimate;

            //Prompt the user for room length and width
            length = GetInput("Please enter the room length in feet: ");
            width = GetInput("Enter the room width in feet: ");

            //Call CalcPaintCost method, input arguments and display result
            paintEstimate = CalcPaintCost(length, width);
            WriteLine($"The cost of painting this room is: ${paintEstimate:F2}");
        }

        //Method to prompt the user for input
        static float GetInput(string prompt)
        {
            WriteLine(prompt);
            return Convert.ToSingle(ReadLine());
        }

        //Calculate painting cost method
        static decimal CalcPaintCost(float roomLength, float roomWidth)
        {
            const float PRICE_PER_SQUARE = 6;
            const float ROOM_HEIGHT = 9;
            float surfaceArea;
            decimal paintCost;

            surfaceArea = 2 * (roomLength * roomWidth + roomLength * ROOM_HEIGHT + roomWidth * ROOM_HEIGHT);
            paintCost = surfaceArea * PRICE_PER_SQUARE;
            return paintCost;
        }
    }
}
