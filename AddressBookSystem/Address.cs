using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class Address
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public int zip;
        public int phoneNumber;
        public Address(string firstName, string lastName, string address, string city, string state, string email, int zip, int phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }
    }
}
