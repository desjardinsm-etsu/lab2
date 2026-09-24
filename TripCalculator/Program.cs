//Part 1: Road Trip

//Questions and Answer
Console.Write("How many miles for your trip? ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can you car go? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations for Part 1
double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;
  
//Print the calculations
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));