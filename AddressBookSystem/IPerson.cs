using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public interface IPerson
    {
        void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, string phoneNumber, string bookName);
        void ViewContact(string name, string bookName);
        void EditContact(string name, string bookName);
        void DeleteContact(string name, string bookName);
        void AddAddressBook(string bookName);
    }
}
