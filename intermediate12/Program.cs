using System;

namespace intermediate12
{
  public class Program {
    public static void Main(string[] args) {
      int[] testArr = new int[] {9,4,6,8,-1};
      // Console.WriteLine(ConvertTemp(23));
      // Console.WriteLine("[{0}]", string.Join(", ", Fib(10)));
      // Console.WriteLine(wordsInString("Hello there a"));
      // Console.WriteLine("[{0}]", string.Join(", ", sqrtArr(testArr)));
      // Console.WriteLine(reverseText("Hello World How are you"));
      // removeElement(testArr, 2);
      // Console.WriteLine("[{0}]", string.Join(", ", testArr));
     

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
      } else if(n == 1) {
        fibs[0] = 0;
        fibs[1] = 1;
        return fibs;
      } else {
        fibs[0] = 0;
        fibs[1] = 1;
        for(int i = 2; i < n; i++) {
          fibs[i] += fibs[i-2] + fibs[i-1];
        }
      }
      return fibs;
    }

    public static int wordsInString(string text) {
      int wordsInText = 0;
      int charsInTextWithWS = 0;
      string textNoSpaces;
      //Clean up ends
      text.Trim();
      charsInTextWithWS = text.Length;
      //Remove White Spaces (Single Line Below From Stack Overflow)
      textNoSpaces = string.Join("", text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
      wordsInText = (text.Length - textNoSpaces.Length);
      if(text.Length - textNoSpaces.Length != 0){wordsInText++;}

      return wordsInText;
    }

    public static double[] sqrtArr(int[] arr) {
      double[] sqrtArr = new double[arr.Length];
      for(int i = 0; i < arr.Length; i++) {
        sqrtArr[i] = Math.Sqrt(arr[i]);
        if (Double.IsNaN(sqrtArr[i])) { sqrtArr[i] = 0; }
      }
      return sqrtArr;
    }

    public static string reverseText(string text) {
      string[] words = text.Split(' ');
      string newText = "";
      for(int i = words.Length-1; i >= 0; i--) {
        newText += $"{words[i]} ";
      }
      return newText;
    }

    public static void removeElement(int[] arr, int x) {
      for(int i = x; i < arr.Length - 1; i++) {
        int temp = arr[i];
        arr[i] = arr[i+1];
        arr[i+1] = temp;
      }
      arr[arr.Length-1] = 0; 
    }
  }
}
