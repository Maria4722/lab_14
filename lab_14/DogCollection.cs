using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_14
{
    [Serializable] // Робимо клас серіалізованим, щоб зберігати його у файл
    public class DogCollection
    {
        // Використовуємо узагальнену колекцію List<T>
        public List<Dog> Dogs { get; private set; }

        public DogCollection()
        {
            Dogs = new List<Dog>();
        }

        /// <summary>
        /// Заповнення колекцію рандомно
        /// </summary>
        public void GenerateRandomDogs(int count)
        {
            Dogs.Clear();
            Random random = new Random();
            string[] breeds = { "Вівчарка", "Такса", "Лабрадор", "Чихуахуа", "Бульдог", "Пудель" };

            for (int i = 0; i < count; i++)
            {
                string id = $"dog-{100 + i}";
                string breed = breeds[random.Next(breeds.Length)];
                Sex sex = (Sex)random.Next(2); 
                decimal price = random.Next(1000, 10001);
                int age = random.Next(1, 6); 
                Dogs.Add(new Dog(id, breed, sex, price, age));
            }
        }

        /// <summary>
        /// Збільшує вартість самок 2-річного віку на 25%.
        /// </summary>
        public void IncreasePriceForTwoYearOldFemales()
        {
            foreach (var dog in Dogs)
            {
                if (dog.Sex == Sex.Female && dog.Age == 2)
                {
                    dog.Price *= 1.25m; 
                }
            }
        }

        /// <summary>
        /// Повертає список собак, відфільтрований за статтю.
        /// </summary>
        public List<Dog> GetDogsBySex(Sex sex)
        {
            // Використовуємо LINQ для простої фільтрації
            return Dogs.Where(d => d.Sex == sex).ToList();
        }

        /// <summary>
        /// Сортує колекцію за ID.
        /// </summary>
        public void SortById()
        {
            Dogs.Sort();
        }

        public void SaveToFile(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                // Серіалізація
                formatter.Serialize(fs, this);
            }
        }

        public static DogCollection LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    return (DogCollection)formatter.Deserialize(fs);
                }
            }
            return new DogCollection(); // Повертаємо порожню колекцію, якщо файл не знайдено
        }
    }
}