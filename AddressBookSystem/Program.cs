using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome To AddressBook *******");

            Person person = new Person("Bishal", "Pradhan", "Btm", "Bengaluru", "Karnataka", "560076", "9439455606", "pbishal60@gmail.com");
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.ReadLine();
        }
    }
}
