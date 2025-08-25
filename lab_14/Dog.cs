using System;

namespace lab_14
{
    /// <summary>
    /// Перерахування для визначення статі.
    /// </summary>
    public enum Sex { Male, Female }

    /// <summary>
    /// Клас для представлення собаки.
    /// [Serializable] дозволяє зберігати об'єкти у файл.
    /// </summary>
    [Serializable]
    public class Dog : IComparable<Dog>
    {
        // Властивості
        public string Id { get; private set; }
        public string Breed { get; private set; }
        public Sex Sex { get; private set; }
        public decimal Price { get; set; } 
        public int Age { get; private set; }

        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public Dog()
        {
            Id = "unknown-000";
            Breed = "невідома";
            Sex = Sex.Male;
            Price = 0;
            Age = 0;
        }

        /// <summary>
        /// Параметризований конструктор з перевірками.
        /// </summary>
        public Dog(string id, string breed, Sex sex, decimal price, int age)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID/кличка не може бути порожнім.", nameof(id));
            if (price < 0)
                throw new ArgumentException("Ціна не може бути від'ємною.", nameof(price));
            if (age < 0)
                throw new ArgumentException("Вік не може бути від'ємним.", nameof(age));

            Id = id;
            Breed = breed;
            Sex = sex;
            Price = price;
            Age = age;
        }

        /// <summary>
        ///IComparable для сортування за ID.
        /// </summary>
        public int CompareTo(Dog other)
        {
            if (other == null) return 1;
            return string.Compare(this.Id, other.Id, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"ID: {Id}, Порода: {Breed}, Стать: {Sex}, Ціна: {Price:C}, Вік: {Age}";
        }
    }
}