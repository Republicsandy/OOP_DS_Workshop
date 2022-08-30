
//Create contact by using name surname phone number and gender and then add contact  using abstract method

using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new AddressBook();
            while (true)
            {
                person.AddPerson();
                person.Display();
            }
        }
    }
}
