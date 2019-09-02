using System;
using System.Collections.Generic;

namespace Fundamental_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string place = "coding dojo";
      Console.WriteLine($"Hello {place}");
      loop255();
      div3or5();
      fizzBuzz();
      int[] set = {4,5,2,1,8};
      bubbleSort(set);
      printList();
    }

    static void loop255()
    {
      int start = 1;
      int stop = 255;
      for (int i = start; i <= stop; i++)
      {
        Console.WriteLine(i);
      }
    }

    static void div3or5()
    {
      int start = 1;
      int stop = 100;
      for (int i = start; i <= stop; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine(i);
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }

    static void fizzBuzz()
    {
      int start = 1;
      int stop = 100;
      for (int i = start; i <= stop; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("FizzBuzz " + i);
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Fizz " + i);
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Buzz " + i);
        }
      }
    }

    //Arrays
    //Declaring an array 
    static void bubbleSort(int[] arr) 
    {

      int[] sortedArr = arr;
      int temp = 0;
      int start = 0;
      int end = arr.Length;

      for(int i = start; i < end; i++)
      {
        for(int j = i+1; j < end; j++)
        {
          if(sortedArr[i] > sortedArr[j]) 
          {
            temp = sortedArr[i]; 
            sortedArr[i] = sortedArr[j];
            sortedArr[j] = temp;
          }
        }
      }
      Console.WriteLine("[{0}]", string.Join(", ", sortedArr));
    }

    static void printList()
    {
      //Initializing an empty list of Motorcycle Manufacturers
      List<string> bikes = new List<string>();
      //Use the Add function in a similar fashion to push
      bikes.Add("Kawasaki");
      bikes.Add("Triumph");
      bikes.Add("BMW");
      bikes.Add("Moto Guzzi");
      bikes.Add("Harley Davidson");
      bikes.Add("Suzuki");
      //Accessing a generic list value is the same as you would an array
      Console.WriteLine(bikes[2]); //Prints "BMW"
      Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");
      Console.WriteLine("[{0}]", string.Join(", ", bikes));

    }
  }// Class End
}// Namespace End
