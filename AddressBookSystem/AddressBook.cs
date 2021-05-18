using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook : IPerson
    {
        List<Person> adressBookList = new List<Person>(); //creating list
        public void addPerson()
        {
            Console.WriteLine("Enter firstName:");//take input  user
            string firstName = Console.ReadLine();//store input firstname variable

            Console.WriteLine("Enter lastName:");//take input  user
            string lastName = Console.ReadLine();//store input lastname variable

            Console.WriteLine("Enter city:");//take input  user
            string city = Console.ReadLine();//store input city variable

            Console.WriteLine("Enter state:");//take input  user
            string state = Console.ReadLine();//store input state variable

            Console.WriteLine("Enter email:");//take input  user
            string email = Console.ReadLine();//store input email variable

            Console.WriteLine("Enter phoneNumber:");//take input  user
            string phoneNumber = Console.ReadLine();//store input phonenumber variable


            Person person = new Person(firstName, lastName, city, state, email, phoneNumber);
            adressBookList.Add(person);   //adding list data person
        }

        public void displayPerson()//body of displayperson interface method
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }

        }
        public void editPerson()//body of editperson interface method
        {

            Console.WriteLine("\n enter First name to edit details:");//take input
            string name = Console.ReadLine();//store input name variable
            foreach (var person in adressBookList)
            {
                if (name.Equals(person.FirstName))
                {

                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("#1 Phone Number");
                    Console.WriteLine("#2 Email");
                    Console.WriteLine("#3 City");
                    Console.WriteLine("#4 State");
                    Console.WriteLine("#5 Quit");
                    int choice = Convert.ToInt32(Console.ReadLine()); //converting into int with the help of ToInt32()

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter new Mobile number:");
                            string mobileNo = Console.ReadLine();
                            person.setPhoneNumber(mobileNo);
                            Console.WriteLine("mobile no. is updated\n");
                            break;
                        case 2:
                            Console.WriteLine("enter new Email-id:");
                            String email = Console.ReadLine();
                            person.setEmail(email);
                            Console.WriteLine("Email-id is updated\n");
                            break;
                        case 3:
                            Console.WriteLine("enter your city");
                            String city = Console.ReadLine();
                            person.setCity(city);
                            break;
                        case 4:
                            Console.WriteLine("enter your state");
                            String state = Console.ReadLine();
                            person.setState(state);
                            person.setState(state);
                            Console.WriteLine("Address is updated\n");
                            break;
                        default:
                            Console.WriteLine("please enter right choice");
                            break;
                    }
                }
                else
                    Console.WriteLine("Person is not registered");
            }
        }

        public void deletePerson()//body of deleteperson interface method
        {

            Console.WriteLine("Enter firstName of the user you want to remove");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove");
            string lastName = Console.ReadLine();

            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
        }
    }
}
