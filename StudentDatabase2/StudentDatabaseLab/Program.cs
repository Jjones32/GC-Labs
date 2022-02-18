// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, for this database each student correlates to a number. Please choose a number 1-3 to view that students data.");
var index = Convert.ToInt32(Console.ReadLine())-1;


//List<string> name = new List<string>();
string[] nameArray = new string[4] { "Jerry", "Beth", "Rick", "Morty" };

Console.WriteLine(nameArray[index]);

Console.WriteLine("You chose " + index + 1 + " which is " + nameArray[index] +
    " What would you like to know? Enter 'hometown' or 'favorite food'.");

//foreach()
//{

//}







//List<string> hometown = new List<string>();
string[] hometownArray = new string[4] { "Detroit", "Columbus", "Springfield", "Pittsburgh" };

//List<string> favoriteFood = new List<string>();

