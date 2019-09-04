using System;
using System.Collections.Generic;

namespace Human_OOP {
  class Wizard : Human {
    public Wizard(string name) : base(name) {
      this.Intelligence = 25;
      this.health = 50;
    } 
    public Wizard(string n, int s, int i, int d, int h) : base(n,s,i,d,h) {}
    
    public override string Attack(Human target) {
      string msg;
      int damage = this.Intelligence * 5;
      target.health -= damage;
      this.health += damage;
      msg = $"{target.Name} lost {damage} health, {target.health} health pts remaining.";
      msg += $"\n{this.Name} gained {damage} health due to special ability, {this.health} health pts remaining.";
      return msg;
    }
    public string Heal(Human target) {
      string msg;
      int healAmt = this.Intelligence * 10;
      target.health += healAmt;
      msg = $"{this.Name} healed {target.Name}, {target.Name} now has {target.health} health.";
      return msg;
    }    
  }
}