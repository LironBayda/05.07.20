using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(false, "red");
            Orange orange = new Orange(3.4f);
            Banana banana = new Banana(true, false, 2.5f);
            Grapes grapes = new Grapes(false, "green");

            Fruit[] fruit = new Fruit[4] { apple, orange, banana, grapes };
            FruitSalad fruitSalad=new FruitSalad(fruit);

            PrintAppleColor( apple);
            printBananaSize( banana);
            PrintCalories( fruitSalad);
            IsMyFavorite(fruitSalad);
           FruitSalad  fruitSaladFromFun= createSalad(fruit);
            Console.WriteLine(fruitSalad.ToString());

            Console.ReadLine();



        }

        private static FruitSalad createSalad(Fruit[] fruit)
        {
            return new FruitSalad(fruit);
        }

        private static void IsMyFavorite(FruitSalad fruitSalad)
        {
            Console.WriteLine($"Contain My Favorite Fruit? {fruitSalad.ContainMyFavoriteFruit()}");
        }

        private static void PrintCalories(FruitSalad fruitSalad)
        {
            Console.WriteLine($"Total Calories: {fruitSalad.GetTotalCalories()}");
        }

        private static void printBananaSize(Banana banana)
        {
            Console.WriteLine($"banana size: {banana._size}");

        }

        private static void PrintAppleColor(Apple apple)
        {
            Console.WriteLine($"apple calories: {apple._calories}");
        }
    }
}
