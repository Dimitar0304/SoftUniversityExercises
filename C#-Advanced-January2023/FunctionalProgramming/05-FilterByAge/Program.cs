using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Person person = new Person(input[0], int.Parse(input[1]));
                persons.Add(person);
            }
            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            Func<Person, int, bool> conditionFilter = GetFilter(condition);
            persons = persons.Where(p => conditionFilter(p, ageCondition)).ToList();

            string formatType = Console.ReadLine();
            Action<Person> formater = GetFormater(formatType);

            foreach (var item in persons)
            {
                formater(item);
            }

            Func<Person, int, bool> GetFilter(string condition)
            {
                if (condition == "older")
                {
                    return (p, value) => p.Age >= value;
                }
                else if (condition == "younger")
                {
                    return (Person p,  int value) => p.Age < value;
                }
                return null;
            }

            Action<Person> GetFormater(string formatType)
            {
                if (formatType=="name age")
                {
                    return p => Console.WriteLine($"{p.Name} {p.Age}");
                }
                if (formatType == "name")
                {
                    return p => Console.WriteLine($"{p.Name}");
                }
                if (formatType == "age")
                {
                    return p => Console.WriteLine($"{p.Age}");
                }
                return null;
            }

        }
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
