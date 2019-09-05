# Hungry Ninja
## Tasks

### Create a Food class

### Create a Buffet class, which will contain a Menu of Food objects
* add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
* build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object

### Create a Ninja class
* add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
* add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
* build out the Eat method that: if the Ninja is NOT full
  * adds calorie value to ninja's total calorieIntake
  * adds the randomly selected Food object to ninja's FoodHistory list
  * writes the Food's Name - and if it is spicy/sweet to the console
* if the Ninja IS full
  * issues a warning to the console that the ninja is full and cannot eat anymore

# Iron Ninja
## Tasks
### IConsumable.cs
Create a the following *IConsumable* interface (code provided), that contains properties for Name, Calories, IsSweet, and IsSpicy, and a method for GetInfo()

### Food.cs
Refactor the former Food class to implement the IConsumable interface (code provided)

### Drink.cs
Create a Drink class that implements the IConsumable interface. Make sure Drink objects are always sweet.

### Ninja.cs
Convert Ninja to an abstract class. Child classes of Ninja should determine when they are full, and how they eat - or rather *consume*, as we now have both Food and Drink. (code provided)

### SweetTooth.cs
Make a child class of Ninja, for a SweetTooth. A SweetTooth should be "full" at 1500 calories. When a SweetTooth "Consumes":

*If NOT Full*
* adds calorie value to SweetTooth's total calorieIntake (+10 additional calories if the consumable item is "Sweet")
* adds the randomly selected IConsumable object to SweetTooth's ConsumptionHistory list
* calls the IConsumable object's GetInfo() method
*If Full*
* issues a warning to the console that the SweetTooth is full and cannot eat anymore

### SpiceHound.cs
Make a child class of Ninja, for a SpiceHound. A SpiceHound should be "full" at 1200 calories. When a SpiceHound "Consumes":

*If NOT Full*
* adds calorie value to SpiceHound's total calorieIntake (-5 additional calories if the consumable item is "Spicy")
* adds the randomly selected IConsumable object to SpiceHound's ConsumptionHistory list
* calls the IConsumable object's GetInfo() method
*If Full*
* issues a warning to the console that the SpiceHound is full and cannot eat anymore