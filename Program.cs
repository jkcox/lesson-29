using System;
using System.Collections.Generic;
using System.Linq;

namespace OverloadingGenericsLinqAlgorithms
{
	class Overloading
	{
        // Implement two overloaded methods named Display.
        // The first overloaded version takes a single parameter of type
        // int and displays that parameter in the console output.
        // The second overloaded version takes a single parameter of type
        // string and displays that parameter in the console output.

        public void Display(int x) {
             Console.WriteLine(x);
        }
        public void Display(string x) {
             Console.WriteLine(x);
        }

	}

	//class IndexerProperty
	//{
 //       // Implement a read-only indexer property that simply
 //       // returns the string representation of its int type index value.
 //       public IndexerProperty() {
 //           myProp = new List<int>();
 //       }
 //       public int myProp { get; set; }
 //       public char this[int index]
 //       {
 //           get 
 //           {
 //               return myProp.ToString();
 //           }
 //       }


	//}

	class Generics
	{
		// Implement a generic method named GenericSwapMethod that takes
		// two parameters of any type and swaps them in a persistent way.
        public void GenericSwapMethod<T>(ref T a, ref T b) {
            T c = b;
            b = a;
            a = c;
        }

	}

	class Linq
	{
		static public void DisplayEvens(int[] numbers)
		{
            // Google for examples on using LINQ query syntax and then
            // implement a LINQ query that selects only those elements
            // in the int array parameter named numbers, and then display
            // the results of the that query in the console output from
            // within a foreach loop.

            var list = numbers.Where(m => m % 2 == 0).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

		}
	}

	class Gauss
	{
		static public int AddIntegersFromOneUpTo(int limit)
		{
			// Google for a description of "Gauss sum of integers"
			// Then implement that algorithm here and return the result.
            var answer = (limit * (limit + 1)) / 2;
            return answer;

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
            // Call the two overloaded versions of the Display method.
            // The first call passes in the int value of 42.
            // The second call passes in the string value of "Hello Overloading".

            var overload = new Overloading();
            overload.Display(42);
            overload.Display("Hello Overloading");

            // Access the indexer property on the IndexerProperty class,
            // specifying the index value of 42, and display the result
            // in the console output.

            //var indexerProp = new IndexerProperty();
            //indexerProp.myProp = 42;

            // Declare two int variables named x and y with the initial
            // values of 3 and 4. Then display the two values on the console.
            // Then call the GenericSwapMethod, passing in the two parameters.
            // After that, display the values on the console output and see
            // that they are swapped.
            int x = 3;
            int y = 4;
            Console.WriteLine($"{x}, {y}");
            var gen = new Generics();
            gen.GenericSwapMethod(ref x, ref y);
            Console.WriteLine($"{x}, {y}");


            // Declare an array of int named numbers and initialize
            // it with the element values: 1, 2, 3, 4, 5, 6, 7, 8.
            // Then call the DisplayEvens method and see that only even
            // elements are displayed.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Linq.DisplayEvens(numbers);


			// Call the AddIntegersFromOneUpTo method with a parameter set to 100.
			// Then display the result on the console output.
			Console.WriteLine(Gauss.AddIntegersFromOneUpTo(100));

		}
	}
}
