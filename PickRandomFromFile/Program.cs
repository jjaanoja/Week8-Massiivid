using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;

            randomFood = GetRandomFromFile("foods"); 

            randomDrink = GetRandomFromFile("drinks");

            randomMovie = GetRandomFromFile("movies");

            Console.WriteLine($"Tonight you will have {randomFood} with {randomDrink} and watch {randomMovie}.");



        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\Janno\Samples\{fileName}.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}