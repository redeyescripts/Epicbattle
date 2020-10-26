using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] heroes = { "Harry Potter", "Luke Skywalker", "Supeman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Vodlemart", "Dart Vader", "Sauron", "Joker", "Harley Quinn" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero}will fight {villain}");
            Random rnd = new Random();


            int heroHP = rnd.Next(5, 11);
            int villainHP = rnd.Next(5, 11);

            Console.WriteLine($"{hero}with {heroHP} HP will fight {villain} " +
                $"{villainHP} HP ");
            while (heroHP > 0 && villainHP > 0)
            {
                Random knd = new Random();
                heroHP = heroHP - rnd.Next(0, 4);
                villainHP = villainHP - rnd.Next(0, 4);

            }
            if (heroHP == 0)
            {
                Console.WriteLine("Dark Side wins!");

            } else
            {
                Console.WriteLine($"{hero} saves the day!");
            }


            Console.ReadLine();
        }
        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }
        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;

        }
        public static int Hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character}hit {strike}!");
            if(strike == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Won {character} good boy");
            }else if(strike == 0 )
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");
            }
        }
    }
}
