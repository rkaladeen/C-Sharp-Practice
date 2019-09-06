using System;

namespace Phone {
  class Program {
    static void Main(string[] args) {
      Galaxy s10 = new Galaxy("s10", 100, "ATT", "Spring");
      Nokia z5 = new Nokia("z5", 100, "Verizon", "Telephone");

      Console.WriteLine(s10.DisplayInfo());
      Console.WriteLine(s10.Ring());
      Console.WriteLine(s10.Unlock());

      Console.WriteLine(z5.DisplayInfo());
      Console.WriteLine(z5.Ring());
      Console.WriteLine(z5.Unlock());

    }
  }
}
