using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public abstract class Person
    {
        public abstract void AddPerson();
        public abstract void Display();
    }
    public class AddressBook : Person
    {
        public string firstName;
        public string lastName;
        public int phoneNumber;
        public string gender;

        public static List<AddressBook> People = new List<AddressBook>();
        public override void AddPerson()
        {
            AddressBook person = new AddressBook();

            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender: ");
            person.gender = Console.ReadLine();

            People.Add(person);
        }
        public void PrintPerson(AddressBook person)
        {
            Console.WriteLine("First Name: " + person.firstName);
            Console.WriteLine("Last Name: " + person.lastName);
            Console.WriteLine("Phone Number: " + person.phoneNumber);
            Console.WriteLine("Gender: " + person.gender);
            Console.WriteLine("-------------------------------------------");
        }
        public override void Display()
        {
            foreach (var person in People)
            {
                PrintPerson(person);
            }
        }
    }
}