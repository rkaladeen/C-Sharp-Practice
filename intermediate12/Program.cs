using System;

namespace intermediate12
{
  public class Program {
    public static void Main(string[] args) {
      Console.WriteLine(ConvertTemp(23));
    }

    public static double ConvertTemp(double temp) {
      double convTemp = ((temp * 9)/5) + 32;
      return convTemp;
    }

    public static int[] Fib(int n) {
      int[] fibs = new int[n];
      if(n == 0) {
        fibs[0] = 0;
        return fibs;
      }
      if(n == 1) {
        fibs[0] = 0;
        fibs[1] = 1;
        return fibs;
      }
      if (n == 2) {
        fibs[0] = 0;
        fibs[1] = 1;
        fibs[2] = 1;
        return fibs;
      }
      else {
        return Fib(n - 1) + Fib(n - 2);
      }
    }


  }
}
