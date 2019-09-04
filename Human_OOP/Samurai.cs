using System;
using System.Collections.Generic;

namespace Human_OOP {
  class Samurai : Human {
    public Samurai(string name) : base(name) {
      this.health = 200;
    } 
    public Samurai(string n, int s, int i, int d, int h) : base(n,s,i,d,h) {}

    public override string Attack(Human target) {
      int initHealth = target.health;
      string msg;
      base.Attack(target);
      if(target.health < initHealth) {
        target.health = 0;
        msg = $"{target.Name} was wiped from existence!";
        return msg;
      }
      msg = $"{target.Name} lost {initHealth - target.health} health!";
      return msg;
    }
    public string Meditate() {
      string meditateMsg;
      this.health = 200;
      meditateMsg = $"{this.Name} now has {this.health} health.";
      return meditateMsg;
    }    
  }
}