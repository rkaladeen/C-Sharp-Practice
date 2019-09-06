namespace HungryNinja {
  class SpiceHound : Ninja {
    public override bool IsFull { get; set; }
    public override string Consume(IConsumable item) {
      string msg = "";
      if (calorieIntake >= 1200 || calorieIntake + item.Calories >= 1200) { 
        IsFull = true;
        msg = $"SpiceHound is full and cannot eat anymore. [Calorie Count - {calorieIntake}]";
      } else {
        calorieIntake += item.Calories;
        if (item.IsSpicy) { calorieIntake -= 5; }
        ConsumptionHistory.Add(item);
        msg = "SpiceHound consumed " + item.GetInfo() + $".[Calorie Count - {calorieIntake}]";
      }
      return msg;
    }
  }
}