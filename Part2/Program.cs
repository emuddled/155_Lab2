/// Lab No. 2		Exercise No. 2
/// File Name: ArcadeRewardCalculator
/// @author: Evan Sinclair
/// Date:  September 4, 2020
///
/// Problem Statement: Get the total number of points recieved from an arcade game. You can 
/// redeem 10 coupons for a candy bar or 3 coupons for a gumball. You prefer candy bars to gumballs.
/// Calculate the number of bars and gumballs that can be purchased             
/// 
/// Overall Plan:
/// 1) Get number of points from the user
/// 2) Calculate the maximum number of bars purchasable
/// 3) Calculate the number of gumballs purchasable with the leftover points
/// 4) Print the results to the console
///

using System;

namespace Part2
{
    class ArcadeRewardCalculator
    {
        static void Main(string[] args)
        {
            
            int points, bars, gumballs;
            
            // Get points from user
            Console.WriteLine("Enter your total points");
            points = Int32.Parse(Console.ReadLine());
            
            // Calculate bars and gumballs
            bars = points / 10;
            gumballs = (points % 10) / 3;

            // Output bars and gumballs 
            Console.WriteLine("You have enough points for " + bars + " bars and " + gumballs + " gumballs");

            Console.ReadLine();
        }
    }
}
