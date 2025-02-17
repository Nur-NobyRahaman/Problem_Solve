﻿//int[] arr1 = { 2, 2, 2 };
//int count = 0;


//for (int i = 0; i < arr1.Length; i++)
//{

//    for (int j = 0; j < arr1.Length; j++)
//    {
//        if (i != j)
//        {

//            if (arr1[i] == arr1[j])
//            {
//                count++;




//            }
//        }

//    }




//    //Console.WriteLine(arr1[i]);
//}
//Console.WriteLine(count);


//using System;

//class Program
//{
//    static void Main()
//    {
//        // The array to analyze
//        int[] array = { 1, 1, 2, 8, 6, 1, 9, 5, 6, 6, 7, 9, 5, 25 };
//        int size = array.Length;

//        // Array to mark visited elements
//        bool[] visited = new bool[size];

//        Console.WriteLine("Value counts in the array:");

//        // Count occurrences of each value
//        for (int i = 0; i < size; i++)
//        {
//            if (visited[i])
//                continue; // Skip already processed elements

//            int count = 1; // Initialize count for the current value

//            for (int j = i + 1; j < size; j++)
//            {
//                if (array[i] == array[j])
//                {
//                    count++;
//                    visited[j] = true; // Mark as processed
//                }
//            }

//            // Display the result for the current value
//            Console.WriteLine($"Value {array[i]}: {count} times");
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
        //// The array to analyze
        //int[] array = { 1, 1, 2, 8, 6, 1, 9, 5, 6, 6, 7, 9, 5, 25 };
        //int size = array.Length;

        //// Array to mark visited elements, using -1 to indicate "already processed"
        //int[] visited = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    visited[i] = 0; // Initialize as unvisited
        //}

        //Console.WriteLine("Value counts in the array:");

        //// Count occurrences of each value
        //for (int i = 0; i < size; i++)
        //{
        //    if (visited[i] == -1)
        //        continue; // Skip already processed elements

        //    int count = 1; // Initialize count for the current value

        //    for (int j = i + 1; j < size; j++)
        //    {
        //        if (array[i] == array[j])
        //        {
        //            count++;
        //            visited[j] = -1; // Mark as processed
        //        }
        //    }

        //    // Display the result for the current value
        //    Console.WriteLine($"Value {array[i]}: {count} times");
        //}

        //int[] array = { 1, 1, 2, 8, 6, 1, 9, 5, 6, 6, 7, 9, 5, 25 };
        //int size = array.Length;
        //Console.WriteLine(size);

        //int[] visited = new int[size];
        //for (int i = 0; i < size; i++) {
        //    visited[i] = 0;
        //}

        //for (int i = 0; i < size; i++) {

        //    if (visited[i] == 1)
        //    {
        //        continue;
        //    }
        //    int count = 1;

        //    for (int j = i+1; j < size; j++) {

        //        if(array[i] == array[j])
        //        {
        //            count++;
        //            visited[i] = 1;
        //            visited[j] = 1;
        //        }
        //    }

        //    Console.WriteLine($"{array[i]} time {count}");
        //}
//    }
//}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // The array to analyze
        int[] array = { 1, 1, 2, 8, 6, 1, 9, 5, 6, 6, 7, 9, 5, 25 };

        // Dictionary to store the count of each value
        Dictionary<int, int> valueCounts = new Dictionary<int, int>();

        // Count the occurrences of each value
        foreach (int value in array)
        {
            if (valueCounts.ContainsKey(value))
            {
                valueCounts[value]++;
            }
            else
            {
                valueCounts[value] = 1;
            }
        }

        // Display the results
        Console.WriteLine("Value counts in the array:");
        foreach (var pair in valueCounts)
        {
            Console.WriteLine($"Value {pair.Key}: {pair.Value} times");
        }
    }
}




