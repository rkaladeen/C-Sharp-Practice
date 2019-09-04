using System;
using System.Collections.Generic;

namespace Human_OOP {
  class Ninja : Human {
    public Ninja(string name) : base(name) {
      this.Dexterity = 175;
    } 
    public Ninja(string n, int s, int i, int d, int h) : base(n,s,i,d,h) {}

    public override string Attack(Human target) {
      string msg;
      int damage = this.Dexterity * 5;
      target.health -= damage;
      Random rand = new Random();
      int chance = rand.Next(1,6);
      if(chance == 1) {
        target.health -= 10;
        msg = $"{target.Name} lost {damage+10} health due to critical hit, {target.health} health pts remaining.";
        return msg;
      }
      msg = $"{target.Name} lost {damage} health, {target.health} health pts remaining.";
      return msg;
    }
    public string Steal(Human target) {
      string stoleMsg;
      target.health -= 5;
      this.health += 5;
      stoleMsg = $"{this.Name} left {target.Name} with {target.health} health, and now has {this.health} health.";
      return stoleMsg;
    }    
  }
}