using System;

class Program
{
    static void Main()
    {
        #region Question1
        // 1. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        Console.WriteLine("Question 1: Merge Two Arrays in Ascending Order\n");
        int[] array1 = { 1, 3, 5, 7 };
        int[] array2 = { 2, 4, 6, 8 };
        int[] mergedArray = MergeSortedArrays(array1, array2);
        Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
        Console.WriteLine();
        #endregion

        #region Question2
        // 2. Write a program in C# Sharp to count the frequency of each element of an array.
        Console.WriteLine("Question 2: Count Frequency of Each Element\n");
        int[] frequencyArray = { 1, 2, 2, 3, 3, 3, 4 };
        CountFrequency(frequencyArray);
        Console.WriteLine();
        #endregion

        #region Question3
        // 3. Write a program in C# Sharp to find maximum and minimum element in an array.
        Console.WriteLine("Question 3: Find Maximum and Minimum\n");
        int[] minMaxArray = { 1, 2, 3, 4, 5 };
        FindMinMax(minMaxArray);
        Console.WriteLine();
        #endregion

        #region Question4
        // 4. Write a program in C# Sharp to find the second largest element in an array.
        Console.WriteLine("Question 4: Find Second Largest Element\n");
        int[] secondLargestArray = { 1, 2, 3, 4, 5 };
        FindSecondLargest(secondLargestArray);
        Console.WriteLine();
        #endregion

        #region Question5
        // 5. Find the longest distance between two equal cells.
        Console.WriteLine("Question 5: Longest Distance Between Two Equal Cells\n");
        int[] distanceArray = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
        FindLongestDistance(distanceArray);
        Console.WriteLine();
        #endregion

        #region Question6
        // 6. Reverse the order of space-separated words.
        Console.WriteLine("Question 6: Reverse Words in a Sentence\n");
        string sentence = "this is a test";
        ReverseWords(sentence);
        Console.WriteLine();
        #endregion

        #region Question7
        // 7. Copy elements of one multidimensional array to another.
        Console.WriteLine("Question 7: Copy Multidimensional Array\n");
        CopyMultidimensionalArray();
        Console.WriteLine();
        #endregion

        #region Question8
        // 8. Print One Dimensional Array in Reverse Order.
        Console.WriteLine("Question 8: Reverse a One-Dimensional Array\n");
        int[] reverseArray = { 1, 2, 3, 4, 5 };
        PrintArrayInReverse(reverseArray);
        Console.WriteLine();
        #endregion

        #region Question9
        // 9. Explain the difference between passing (Value type parameters) by value and by reference.
        Console.WriteLine("Question 9: Passing Value Type Parameters by Value and by Reference\n");
        int a = 10;
        ModifyValue(a);
        Console.WriteLine("After passing by value: " + a);
        ModifyValue(ref a);
        Console.WriteLine("After passing by reference: " + a);
        Console.WriteLine();
        #endregion

        #region Question10
        // 10. Explain the difference between passing (Reference type parameters) by value and by reference.
        Console.WriteLine("Question 10: Passing Reference Type Parameters by Value and by Reference\n");
        int[] numbers = { 1, 2, 3 };
        ModifyArray(numbers);
        Console.WriteLine("After passing by value: " + string.Join(", ", numbers));
        ModifyArray(ref numbers);
        Console.WriteLine("After passing by reference: " + string.Join(", ", numbers));
        Console.WriteLine();
        #endregion

        #region Question11
        // 11. Write a function that accepts 4 parameters and returns the result of summation and subtraction.
        Console.WriteLine("Question 11: Function for Summation and Subtraction\n");
        int resultSum, resultSub;
        SummationAndSubtraction(10, 5, out resultSum, out resultSub);
        Console.WriteLine($"Sum: {resultSum}, Subtraction: {resultSub}");
        Console.WriteLine();
        #endregion

        #region Question12
        // 12. Function to calculate sum of individual digits of a number.
        Console.WriteLine("Question 12: Sum of Individual Digits\n");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum of digits: " + SumOfDigits(number));
        Console.WriteLine();
        #endregion

        #region Question13
        // 13. Check if a number is prime.
        Console.WriteLine("Question 13: Prime Check Function\n");
        Console.Write("Enter a number: ");
        int primeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Is Prime: " + IsPrime(primeNumber));
        Console.WriteLine();
        #endregion

        #region Question14
        // 14. Find minimum and maximum in an array using reference parameters.
        Console.WriteLine("Question 14: Min and Max in Array using Reference Parameters\n");
        int[] array = { 5, 1, 9, 2, 8 };
        MinMaxArray(array, out int min, out int max);
        Console.WriteLine($"Min: {min}, Max: {max}");
        Console.WriteLine();
        #endregion

        #region Question15
        // 15. Calculate factorial iteratively.
        Console.WriteLine("Question 15: Iterative Factorial Function\n");
        Console.Write("Enter a number: ");
        int factNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial: " + CalculateFactorial(factNumber));
        Console.WriteLine();
        #endregion

        #region Question16
        // 16. Modify a letter in a string at a certain position.
        Console.WriteLine("Question 16: Modify Character in String\n");
        Console.WriteLine(ChangeChar("hello", 1, 'a'));
        Console.WriteLine();
        #endregion
    }

    static void ModifyValue(int x)
    {
        x = 20;
    }

    static void ModifyValue(ref int x)
    {
        x = 20;
    }

    static void ModifyArray(int[] arr)
    {
        arr[0] = 99;
    }

    static void ModifyArray(ref int[] arr)
    {
        arr = new int[] { 99, 99, 99 };
    }

    static void SummationAndSubtraction(int a, int b, out int sum, out int sub)
    {
        sum = a + b;
        sub = a - b;
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void MinMaxArray(int[] array, out int min, out int max)
    {
        min = int.MaxValue;
        max = int.MinValue;
        foreach (int num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
    }

    static int CalculateFactorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static string ChangeChar(string input, int position, char newChar)
    {
        char[] chars = input.ToCharArray();
        chars[position] = newChar;
        return new string(chars);
    }
