//System.Linq namespace for more array methods

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numery = { 3, 4, 3, -5, 543, 66, 77, 32, 5, 7, 8, 9, 10, 7, 45 };
            Console.WriteLine("Max value found in the array: " + numery.Max());
            Console.WriteLine("Min value found in the array: " + numery.Min());
            Console.WriteLine("Sum of all the numbers found in the array: " + numery.Sum());

        }
    }
}

