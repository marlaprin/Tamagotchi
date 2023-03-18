using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Dog
    {
        private int hunger; // Голод
        private int happiness; // Счастье
        private int energy; // Энергия
        private int age; // Возраст

        public Dog()
        {
            hunger = 50;
            happiness = 50;
            energy = 50;
            age = 0;
        }

        // Методы для изменения показателей
        public void Feed()
        {
            hunger -= 10;
            happiness += 5;
        }

        public void Play()
        {
            happiness += 10;
            energy -= 10;
        }

        public void Sleep()
        {
            energy += 10;
            hunger += 5;
        }

        // Метод для получения текущего состояния животного
        public string GetStatus()
        {
            string status = "Голод: " + hunger + ", Счастье: " + happiness + ", Энергия: " + energy + ", Возраст: " + age;
            return status;
        }

        // Метод для обновления животного каждый день
        public void Update()
        {
            hunger += 5;
            happiness -= 5;
            energy -= 5;
            age += 1;
        }
    }
}