namespace HungryNinja {
  class Drink : IConsumable {
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy { get; set; }
    public bool IsSweet {get;set;}
    
    public string GetInfo() {
      return $"{Name} (Drink).  Calories: {Calories}.  Sweet?: {IsSweet}";
    }

    public Drink(string name, int calories) {
      Name = name;
      Calories = calories;
      IsSweet = true;
    }
  }
}