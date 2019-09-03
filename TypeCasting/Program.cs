using System;
using System.Collections.Generic;

namespace TypeCasting
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Type Casting Example");
      List<object> objs = new List<object>();
      List<string> objsNewType = new List<string>();
      objs.Add(7);
      objs.Add(28);
      objs.Add(-1);
      objs.Add(true);
      objs.Add("Chair");
      int total = 0;
      int temp = 0;
      foreach(object obj in objs)
      {
        Console.WriteLine(obj);
        if(obj is int)
        {
          temp = (int)obj;
          total += temp;
        }
      }
      Console.WriteLine("Total: "+total);
    }
  }
}
