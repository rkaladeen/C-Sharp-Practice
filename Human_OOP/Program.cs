using System;

namespace Human_OOP {
  class Program {
    static void Main(string[] args) {
      Human john = new Human("John");
      Human jane = new Human("Jane");
      Console.WriteLine(john.Attack(jane));
    }
  }
}
