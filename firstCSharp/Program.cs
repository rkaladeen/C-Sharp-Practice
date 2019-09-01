using System;

namespace firstCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      string place = "coding dojo";
      Console.WriteLine($"Hello {place}");
      // loop255();
      // div3or5();
      // fizzBuzz();
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
        } else if (i % 5 == 0) 
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
  }
}
