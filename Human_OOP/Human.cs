using System;
using System.Collections.Generic;

namespace Human_OOP {
  class Human {
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health {get;set;}
    public Human(string name) {
      this.Name = name;
      this.Strength = 5;
      this.Intelligence = 5;
      this.Dexterity = 3;
      this.health = 100;
    }
    
    public Human(int s, int i, int d, int h) {
      this.Strength = s;
      this.Intelligence = i;
      this.Dexterity = d;
      this.health = h;
    }    
    public int Attack(Human target) {
      int damage = this.Strength * 5;
      target.health -= damage;
      return target.health;
    }
  }
}