using System;

namespace pairProduct
{
    class Program
    {
        public static int array_adjacent_elements_product(int[] input_array)
        {
            int array_index = 0;
            int product = input_array[array_index] * input_array[array_index + 1];

            array_index++;
            while (array_index + 1 < input_array.Length)
            {
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                        (input_array[array_index] * input_array[array_index + 1]) :
                        product;
                array_index++;        
            }

            return product;
        }
        public static void Main()
        {
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1,-1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }
// The question mark is what is known as the ternary operator. It is a shorthand notation for
// If <condition> then <expression 1> else <expression 2>
// and has the form <condition> ? <expression 1> : <expression 2>
// and is usually used in conjuction with an assignment statement.
// Your statement will evaluate to a comma when both role and roleUp are not 
// empty otherwise it will evaluate to an empty string (why not String.Empty again?). 
// It looks like it might be used to separate role and roleUp by a comma when they both have values. 
// If roleUp is a comma separated list of roles, then this statement decides when to add the comma.
    }
}
