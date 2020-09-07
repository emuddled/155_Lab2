/// Lab No. 2		Exercise No. 1
/// File Name: MyFirstProgram
/// @author: Evan Sinclair
/// Date:  September 4, 2020
///
/// Problem Statement: Ask the user to enter three numbers. Calculate the sum and product of
/// these three numbers. Divide the sum of the three numbers by the product of the same three numbers.
/// Display Result
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum and product of the integers
/// 4) Print the sum of the integers to the screen
/// 5) Print the product of the integers to the screen
/// 6) Print the sum / product to the screen
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you and then divide that result by the product.");
            Console.WriteLine("Enter a number and then press enter 3 times.");

            // declare five integer variables
            int n1, n2, n3, product, sum;

            // read in n1, n2, and n3
            
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum and product of these three numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;

            // print the sum, the product, and the sum / product 
            Console.WriteLine("The sum of the three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of the three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("The sum divided by the product is");
            Console.WriteLine(sum / product);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}