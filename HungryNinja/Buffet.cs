using System.Collections.Generic;
class Buffet {
  public List<Food> Menu;
     
  public Buffet() {
    Menu = new List<Food>() {
      new Food("Example", 1000, false, false)
    };
  }
    
  public Food Serve() {

  }
}