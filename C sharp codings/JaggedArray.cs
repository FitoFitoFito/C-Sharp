using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        // This is a class to understand jagged arrays

        static void Main(string[] args)
        {
            // This could be called an array of arrays, in this case this is only 1-dimension.
            // the memory asigned its only written on the first [] as all I'm doing is to create n arrays.
            // Here's what you have said so far; I want to create 3 arrays inside name JaggedArray.
            
            int[][] name = new int[3][]; // There is 2 ways to iniciate the jaggedArray when its been created like this.

            // Number 1: "Name"[array you want to select] = new (because you haven't stablish the size for that internal array) int[number of values you will want to have]
            name[0] = new int[7];
            name[1] = new int[4];   /*In these 3 cases I'm saying that I want to save memo for 7 values, 4 values and 3 values.*/
            name[2] = new int[3];

            // Number 2: Same but this time I know which values I want on each array, so instead of stablish the size I add the values, which at the end will reserve memory.
            name[0] = new int[] {5,16,2,1,45,68,3};
            name[1] = new int[] {5,16,2,1};             /*In these 3 cases I'm saying that these are the values I want to have on each array inside my name JaggedArray*/
            name[2] = new int[] {5,16,2};

            
            // Another option to initialize the array is by adding directly the values to the array name:
            int[][] name = new int[][]      // You don't reserve memo as you are going to add the values to the proper arrays.
            {
                new int[] {5,16,2,1,45,68,3},
                new int[] {5,16,2,1},           // Note 3 things, all the initialization happens inside the {}, to separate one array from the other, a comma is used,
                new int[] {5,16,2}              // and to terminate the line and close the initialization a semicolon is used.
            };
            // You can use shorthand to that last initialization which is by omiting the new int[][] and leaving the rest as it is.
        }
    }
}