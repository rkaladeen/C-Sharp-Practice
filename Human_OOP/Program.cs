using System;

namespace Human_OOP {
  class Program {
    static void Main(string[] args) {
      Human john = new Human("John");
      Human jane = new Human("Jane");

      Wizard wiz1 = new Wizard("Wiz 1");
      Wizard wiz2 = new Wizard("Wiz 2");

      Samurai samurai1 = new Samurai("samurai 1");
      Samurai samurai2 = new Samurai("samurai 2");

      Ninja ninja1 = new Ninja("ninja 1");
      Ninja ninja2 = new Ninja("ninja 2");

      // Console.WriteLine(john.Attack(jane));

      // Console.WriteLine(wiz1.Attack(john));
      // Console.WriteLine(wiz1.Heal(john));

      // Console.WriteLine(samurai1.Attack(john));
      // Console.WriteLine(john.Attack(samurai1));
      // Console.WriteLine(samurai1.Meditate());

      // Console.WriteLine(ninja1.Attack(john));
      // Console.WriteLine(ninja1.Steal(john));

    }
  }
}
