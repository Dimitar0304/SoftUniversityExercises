using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public List<Person> People
        {
            get
            {
                return this.people;
            }
            set
            {
                this.people = value;
            }
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = new Person("",0);
            foreach (var item in people)
            {
                if (item.Age>oldestPerson.Age||item.Age ==0)
                {
                    oldestPerson = item;
                }
            }
            return oldestPerson;
        }
    }
}
