using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Game
    {
        private Dog pet;

        public Game()
        {
            pet = new Dog();
        }

        // Методы для выполнения действий с животным
        public void FeedPet()
        {
            pet.Feed();
        }

        public void PlayWithPet()
        {
            pet.Play();
        }

        public void PutPetToSleep()
        {
            pet.Sleep();
        }

        // Метод для вывода состояния животного на экран
        public void PrintStatus()
        {
            Console.WriteLine(pet.GetStatus());
        }

        // Метод для запуска игры
        public void Start()
        {
            while (true)
            {
                pet.Update();
                PrintStatus();
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1. Покормить животное");
                Console.WriteLine("2. Поиграть с животным");
                Console.WriteLine("3. Уложить животное спать");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    FeedPet();
                }
                else if (input == "2")
                {
                    PlayWithPet();
                }
                else if (input == "3")
                {
                    PutPetToSleep();
                }
            }
        }
    }
}
