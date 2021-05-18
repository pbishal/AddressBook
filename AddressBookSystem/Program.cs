using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome To AddressBook *******");
            AddressBook addressBook = new AddressBook(); //object of AddessBook class

            bool ProgramIsRunning = true;
            while (ProgramIsRunning)
            {
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("#1 Add new user");
                Console.WriteLine("#2 Display user information");
                Console.WriteLine("#3 Edit user information");
                Console.WriteLine("#4 Delete existing user");
                Console.WriteLine("#5 Exit");
                int num = Convert.ToInt32(Console.ReadLine());//convert into int with the help of ToInt32()

                switch (num)//using switch case
                {
                    case 1:
                        addressBook.addPerson();
                        break;
                    case 2:
                        addressBook.displayPerson();
                        break;
                    case 3:
                        addressBook.editPerson();
                        break;
                    case 4:
                        addressBook.deletePerson();
                        break;
                    case 5:
                        ProgramIsRunning = false;
                        break;
                }//end switch case
            }
        }
    }
}
