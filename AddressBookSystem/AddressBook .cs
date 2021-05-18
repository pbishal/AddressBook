using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
        class AddressBook : IPerson
        {
            private Dictionary<string, Person> addressBook = new Dictionary<string, Person>(); //create addressBook Dictionary and string is (Key)(string=datatype) and person is (value)

            //method of interface
            public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
            {
                Person contact = new Person(); // creating object of person class
                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.Address = address;
                contact.City = city;
                contact.State = state;
                contact.Email = email;
                int Zip = zip;
                contact.PhoneNumber = phoneNumber;
                addressBook.Add(contact.FirstName, contact);
            }
            public void ViewContact()
            {
                //all Tvalues in dictionary access by KeyValuePair Class
                foreach (KeyValuePair<string, Person> item in addressBook) //print all values using foreach  in addressBook Dictionary
                {
                    Console.WriteLine("First Name : " + item.Value.FirstName);
                    Console.WriteLine("Last Name : " + item.Value.LastName);
                    Console.WriteLine("Address : " + item.Value.Address);
                    Console.WriteLine("City : " + item.Value.City);
                    Console.WriteLine("State : " + item.Value.State);
                    Console.WriteLine("Email : " + item.Value.Email);
                    Console.WriteLine("Zip : " + item.Value.Zip);
                    Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");

                }
            }
            public void EditContact(string name) //method in inteface pass argument name
            {
                foreach (KeyValuePair<string, Person> item in addressBook) //use loop foreach
                {
                    if (item.Key.Equals(name))
                    {

                        Console.WriteLine("Choose What to Edit \n 1. FirstName\n2. LastName\n3. Address\n4. city\n5. State\n6. Email\n7. Zip \n8. PhoneNumber\n");

                        int choice = Convert.ToInt32(Console.ReadLine()); //convert string and store choice
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name :"); //take input
                                item.Value.FirstName = Console.ReadLine(); //store firstName string in iten.value
                                break;
                            case 2:
                                Console.WriteLine("Enter Last Name :");//take input
                                item.Value.LastName = Console.ReadLine();//store last name in value
                                break;
                            case 3:
                                Console.WriteLine("Enter Address :");
                                item.Value.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter City :");
                                item.Value.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter State :");
                                item.Value.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter Email :");
                                item.Value.Email = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter Zip :");
                                item.Value.Zip = Convert.ToInt32(Console.ReadLine()); //convert string into int and store it
                                break;
                            case 8:
                                Console.WriteLine("Enter Phone Number :");
                                item.Value.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
        }
    }
