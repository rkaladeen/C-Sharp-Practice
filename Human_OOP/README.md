## Assignment1: Human
### Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
* Add an additional private field for health (int), and a public property to access or "get" health
* Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
* Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
* Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.

## Assignment2: Wizard, Ninja, Samurai
### Create a class for a Ninja, a Wizard, and a Samurai. 
* Wizard should have a default health of 50 and Intelligence of 25
* Ninja should have a default dexterity of 175
* Samurai should have a default health of 200
* Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
* Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
* Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
* Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
* Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
* Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.