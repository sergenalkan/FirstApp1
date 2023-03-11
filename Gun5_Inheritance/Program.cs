using System;

namespace Gun5_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] {
                new Customer { FirstName = "Ediz" },
                new Student { FirstName = "Sercan" },
                new Person { FirstName = "Sergen" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        //interfaceler birden fazla implement edilir, inheritler olamaz(bir çocucuğun tek babası olur)
        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string School { get; set; }
        }
    }
}
