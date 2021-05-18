using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome To AddressBook *******");
            AddressBook addressBook = new AddressBook(); //object of AddessBook class

            int Choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter First Name :");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name :");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address :");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City :");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State :");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Email :");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Zip :");
                int zip = Convert.ToInt32(Console.ReadLine());//conver into int using ToInt32()
                Console.WriteLine("Enter Phone Number :");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);


                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact();
                        break;

                    case 4:
                        Console.WriteLine("It is Not Found Any Information.");
                        break;
                }
            } while (Choice != 4);
        }
    }
}
