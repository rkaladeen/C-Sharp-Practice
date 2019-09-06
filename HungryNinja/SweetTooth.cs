namespace HungryNinja {
  class SweetTooth : Ninja {
    public override bool IsFull { get; set; }
    public override string Consume(IConsumable item) {
      string msg = "";
      if(calorieIntake == 1500 || calorieIntake + item.Calories >= 1500) {
        IsFull = true;
        msg = $"SweetTooth is full and cannot eat anymore. [Calorie Count - {calorieIntake}]";
      } else {
        calorieIntake += item.Calories;
        if(item.IsSweet) {calorieIntake += 10;}
        ConsumptionHistory.Add(item);
        msg = "SweetTooth consumed " + item.GetInfo() + $".[Calorie Count - {calorieIntake}]";
      }
      return msg;
    }
  }
}