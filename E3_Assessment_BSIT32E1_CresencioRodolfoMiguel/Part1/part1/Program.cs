using System;

class Program
{
    static void Main(string[] args)
    {

        //Part 1 - Calculate the area of the triangle
        Console.WriteLine("1.) Calculate the area of the triangle: ");
        double baseLength = ReadValidDouble("Enter the base of the triangle: ");
        double height = ReadValidDouble("Enter the height of the triangle: ");
        double area = 0.5 * baseLength * height;
        Console.WriteLine($"The area of the triangle is: {area}");

        //Declare an array of 5 integers and find the largest element
        Console.WriteLine("\nInput 5 Integers for the array:");
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid Input. Please input an Integer.");
                i--;
            }
        }

        Console.WriteLine("\nArray Elements: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("\nLargest element in the array: " + max);

        //Print each number along with its square root
        Console.WriteLine("\n3.) Print each number along with its square root");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"Number: {i}, Square Root: {Math.Sqrt(i)}");
    }

    static double ReadValidDouble(string prompt)
    {
        double value;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out value) || value <= 0);
        return value;
    }

    static string ReadFormula(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int CalculateFormula(string formula, int n)
    {
        return formula switch
        {
            "n^2" => n * n,
            _ => throw new ArgumentException("Invalid Formula"),
        };
    }

    static int FindMaxElement(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;
    }
}
