using System;

namespace MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MDArray();
        }
        static void MDArray() 
        {
          int[,] timeTable = new int[11,11];
          string tempStr = "";
          
          for(int row = 1; row <= 10; row++)
          {
            tempStr = "";
            for(int col = 1; col <= 10; col++)
            {
              timeTable[row, col] = row*col;
              tempStr += $"{timeTable[row, col]},";
            }
            Console.WriteLine($"[ {tempStr} ]");
          }
        }
    }
}
