using Review;

// Polymorphism
//int number = "fifteen"; // a string is being stored in an integer, THIS IS NOT ALLOWED! (type mismatch)
//Pet pet = new RoboticPet(); // this is allowed because of inheritence, and it exemplifies polymorphism

//RoboticPet r = (RoboticPet) new Pet(); //utilizes type casting to take a parent class to a child class variable

// Collections and Loops
// Lists and Foreach Loops

// What is a list? A collection of objects with a fixed type but a variable length.
// Lists can grow and shrink, but must always contain objects of a particular type
// We use lists the same as any variable/property
// The <> represent the type of list we will be using
List<string> anime = new List<string>();
// lists start with 0 objects in them
Console.WriteLine(anime.Count);

anime.Add("Kuroko's Basketball");
// anime -> { "Kuroko's Basketball" }
Console.WriteLine(anime.Count);
anime.Remove("Kuroko's Basketbal");
// anime -> { "Kuroko's Basketball" }
anime.RemoveAt(0);
// anime -> { }
Console.WriteLine(anime.Count);