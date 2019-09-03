using System;
using System.Collections.Generic;

namespace puzzles {
  public class Program {
    public static void Main(string[] args) {
      // Console.WriteLine("[{0}]", string.Join(", ", RandomArray(10)));
      // Console.WriteLine(TossCoin());
      // Console.WriteLine(TossMultipleCoin(10));
      Console.WriteLine("[{0}]", string.Join(", ", Names()));

    }

    public static int[] RandomArray(int size) {
      Random rand = new Random();
      int tempRandom;
      int[] randArr = new int[size];
      for(int i = 0; i < randArr.Length; i++) {
        tempRandom = rand.Next(5,26);
        randArr[i] = tempRandom;
      }
      return randArr;
    }

    public static string TossCoin() {
      string play;
      Random rand = new Random();
      int randomInt = rand.Next(1,3);
      if(randomInt == 1) {
        play = "Heads";
      }else{
        play = "Tails";
      }
      return play;
    }

    public static double TossMultipleCoin(int num) {
      int gotHeads = 0;
      double ratio;
      for(int i = 0; i < num; i++) {
        if(TossCoin() == "Heads") { gotHeads ++; }
      }
      ratio = (double)gotHeads/num;
      return ratio;
    }

    public static List<string> Names() {
      List<string> names = new List<string>();
      names.Add("Todd");
      names.Add("Tiffany");
      names.Add("Charlie");
      names.Add("Geneva");
      names.Add("Sydney");

      Random rand = new Random();
      int listSize = names.Count;

      while (listSize > 1) {  
        listSize --;  
        int ran = rand.Next(listSize + 1);  
        string temp = names[ran];  
        names[ran] = names[listSize];  
        names[listSize] = temp;  
    }  
      return names;
    }
  }
}
