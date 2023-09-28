﻿using Microsoft.AspNetCore.Http.HttpResults;
using RestWithAspNet.Model;

namespace RestWithAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
           return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name"+i,
                LastName = "Person Last Name"+i,
                Address = "Person Address" + i,
                Gender = "Male"+i
            };
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person { 
                Id = 1,
                FirstName = "First Name Test",
                LastName = "Last Name Test",
                Address = "Teste Ad",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
