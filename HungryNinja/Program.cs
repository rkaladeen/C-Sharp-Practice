using System;
using System.Collections.Generic;

namespace HungryNinja {
  class Program {
    static void Main(string[] args) {
      Buffet buffet = new Buffet();
      SpiceHound john = new SpiceHound();
      SweetTooth jane = new SweetTooth();
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));
      Console.WriteLine(john.Consume(buffet.Serve()));

      Console.WriteLine("\n");
      
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));
      Console.WriteLine(jane.Consume(buffet.Serve()));


    }
  }
}
