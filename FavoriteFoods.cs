using System;



namespace FavoriteFoods 
{
    string[] favorite = new string[3]; // array opening

    for (int i = 1; i <= 3; i++)  // for and foreach loop
    {
        Console.WriteLine($"what is your #{i} favorite food?"); // asks what is your three favorite foods
        favorite[i - 1] = Console.ReadLine(); // reads code
    }


    Console.WriteLine("Here are your top foods --"); // what the program will display
    foreach(string f in favourite)
        Console.WriteLine($"--- {f}"); // displaces your favorite food

}
