using System;
using System.Collections.Generic;

namespace Human_OOP {
  class Human {
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int health {get;set;}
    public Human(string name) {
      this.Name = name;
      this.Strength = 5;
      this.Intelligence = 5;
      this.Dexterity = 3;
      this.health = 100;
    }
    
    public Human(string n, int s, int i, int d, int h) {
      this.Name = n;
      this.Strength = s;
      this.Intelligence = i;
      this.Dexterity = d;
      this.health = h;
    }    
    public virtual string Attack(Human target) {
      string msg;
      int damage = this.Strength * 5;
      target.health -= damage;
      msg = $"{target.Name} lost {damage} health, {target.health} health pts remaining.";
      return msg;
    }
  }
}