using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "popcorn", "salad", "sushi" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movies = { "Titanic", "Marley and me", "Tag", "Walk the line" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");


        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        
        private static string PickRandomElementFromArray(string [] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;

            

        }
    }
}
