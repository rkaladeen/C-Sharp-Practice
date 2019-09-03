using System;
using System.Collections.Generic;

namespace basic13 {
  public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Basic 13");
      int[] testArray = new int[] {1,2,3,-4,5};
      // printNumbers(1,255);
      // printOdds(1,255);
      // printSum(1,255);
      // loopArray(testArray);
      // Console.WriteLine(findMax(testArray));
      // getAverage(testArray);
      // Console.WriteLine("[{0}]", string.Join(", ", oddArray(1,255)));
      // Console.WriteLine(greaterThanY(testArray, 2));
      // squareArrayValues(testArray);
      // EliminateNegatives(testArray);
      // MinMaxAverage(testArray);
      // ShiftValues(testArray);
      Console.WriteLine("[{0}]", string.Join(", ", NumToString(testArray)));
    }

    public static void printNumbers(int start, int stop) {
      // Print all of the integers from 1 to 255.
      int[] temp = new int[stop];
      for(int i = start; i <= temp.Length; i++) {
        temp[i-1] = i;
      }
      Console.WriteLine("[{0}]", string.Join(", ", temp));
    }

    public static void printOdds(int start, int stop) {
      // Print all of the odd integers from 1 to 255.
      for(int i = start; i <= stop; i = i+2) {
        Console.WriteLine(i);
      }
    }

    public static void printSum(int start, int stop) {
      // Print all of the numbers from 0 to 255, 
      // but this time, also print the sum as you go. 
      for(int i = start; i <= stop; i++) {
        int temp = 0;
        for(int j = start; j <= i; j++) {
          temp += j;
        }
        Console.WriteLine(temp);
      }
    }
      
    public static void loopArray(int[] numbers) {
      // Write a function that would iterate through each item of the given integer array and 
      // print each value to the console.
      Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    public static int findMax(int[] numbers) {
      // Write a function that takes an integer array and prints and returns the maximum value in the array. 
      // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
      // or even a mix of positive numbers, negative numbers and zero.
      int max = numbers[0];
      for(int i = 1; i <= numbers.Length; i++) {
        if(i > max) {
          max = i;
        }
      }
      return max;
    }

    public static void getAverage(int[] numbers) {
      // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
      // For example, with an array [2, 10, 3], your program should write 5 to the console.
      int sum = numbers[0];
      for(int i = 1; i <= numbers.Length; i++) {
        sum += i;
      }
      double avg = sum/numbers.Length;
      Console.WriteLine(avg);
    }

    public static int[] oddArray(int start, int stop) {
      // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
      // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
      if(start % 2 == 0) {start ++;} //HandlingEdge Cases
      if(stop % 2 == 1) {stop ++;} //HandlingEdge Cases
      int[] temp = new int[(stop/2)];
      int counter = 0;
      for(int i = start; i <= stop; i++) {
        if(i % 2 == 1) {
          temp[counter] = i;
          counter ++;
        }
      }
      return temp;
    }

    public static int greaterThanY(int[] numbers, int y) {
      // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
      // That are greater than the "y" value. 
      // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
      // (since there are two values in the array that are greater than 3)
      int counter = 0;
      for(int i = 0; i < numbers.Length; i++) {
        if(numbers[i] > y) {
          counter ++;
        }
      }
      return counter;
    }

    public static void squareArrayValues(int[] numbers)
    {
      // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
      // For example, [1,5,10,-10] should become [1,25,100,100]
      int[] squaredArr = new int[numbers.Length];
      for(int i = 0; i < numbers.Length; i++) {
        squaredArr[i] = numbers[i] * numbers[i];
      }
      Console.WriteLine("[{0}]", string.Join(", ", squaredArr));
    }

    public static void EliminateNegatives(int[] numbers)
    {
      // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
      // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
      for(int i = 0; i < numbers.Length; i++) {
        if(numbers[i] < 0) {numbers[i] = 0;}
      }
      Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    public static void MinMaxAverage(int[] numbers)
    {
      // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
      // the minimum value in the array, and the average of the values in the array.
      Dictionary <string,object> data = new Dictionary<string,object>();
      int max = numbers[0];
      int min = numbers[0];
      int sum = numbers[0];
      decimal avg = numbers[0];

      for(int i = 0; i < numbers.Length; i++) {
        sum += numbers[i];
        if(numbers[i] > max) { max = numbers[i]; } 
        else if(numbers[i] < min) { min = numbers[i]; }
      }
      avg = (decimal)sum/numbers.Length;

      data.Add("Max Value: ", max);
      data.Add("Min Value: ", min);
      data.Add("  Average: ", avg);
      foreach (KeyValuePair<string,object> entry in data)
      {
        Console.WriteLine(entry.Key + " > " + entry.Value);
      }
    }

    public static void ShiftValues(int[] numbers)
    {
      // Given an integer array, say [1, 5, 10, 7, -2], 
      // Write a function that shifts each number by one to the front and adds '0' to the end. 
      for(int i = 0; i < numbers.Length-1; i++) {
        numbers[i] = numbers[i+1];
      }
      numbers[numbers.Length-1] = 0;
      Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    public static object[] NumToString(int[] numbers)
    {
    // Write a function that takes an integer array and returns an object array 
    // that replaces any negative number with the string 'Dojo'.
    object[] arr = new object[numbers.Length];
    for(int i = 0; i < numbers.Length; i++) {
      if(numbers[i] < 0) {
        arr[i] = "Dojo";
      }else{
        arr[i] = numbers[i];
      }
    }
    return arr;
    }
  }
}
