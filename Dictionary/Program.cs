using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> dictionary = new SortedList<string, string>();
            dictionary.Add("Украина", "Ukraine");
            dictionary.Add("Германия", "Germany");
            dictionary.Add("Италия", "Italy");
            dictionary.Add("Франция", "France");
            dictionary.Add("Польша", "Poland");
            dictionary.Add("Молдова", "Moldova");
            dictionary.Add("Румыния", "Romania");
            dictionary.Add("Латвия", "Latvia");
            dictionary.Add("Литва", "Lithuania");
            dictionary.Add("Дания", "Denmark");
            dictionary.Add("Швеция", "Sweden");
            dictionary.Add("Швейцария", "Switzerland");
            dictionary.Add("Норвегия", "Norway");
            dictionary.Add("Австрия", "Austria");
            dictionary.Add("Португалия", "Portugal");
            dictionary.Add("Испания", "Spain");
            dictionary.Add("Словакия", "Slovakia");
            dictionary.Add("Чехия", "Czech");

            Console.Write("Введите страну перевод которой вам надо -> ");
            string NameCantry = Console.ReadLine();

            if (dictionary.ContainsKey(NameCantry))
            {
                Console.WriteLine(" '{0}' - '{1}'", NameCantry, dictionary[NameCantry]);
            }
            else if (dictionary.ContainsValue(NameCantry))
            {
                Console.WriteLine("'{0}' - '{1}'", NameCantry, dictionary.First(x => x.Value == NameCantry).Key);
            }
            else
            {
                Console.WriteLine($"Данного {NameCantry} слова нет в словаре\nМожете ввести его перевод -> ");
                string translator = Console.ReadLine();
                dictionary.Add(NameCantry, translator);
            }
        }
    }
}
