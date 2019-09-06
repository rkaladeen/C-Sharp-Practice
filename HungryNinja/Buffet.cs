using System;
using System.Collections.Generic;
namespace HungryNinja {
  class Buffet {
    public List<IConsumable> Menu;
    public Buffet() {
      Menu = new List<IConsumable>() {
        new Food("SwtFoodExample1", 800, false, true),
        new Food("SpcyFoodExample2", 500, true, false),
        new Drink("DrinkExample1", 100),
        new Drink("DrinkExample2", 200)
      };
    }
    public IConsumable Serve() {
      Random rand = new Random();
      int numRand = rand.Next(0, Menu.Count);
      return Menu[numRand];
    }
  }
}