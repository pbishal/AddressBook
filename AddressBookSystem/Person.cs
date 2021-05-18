using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
	public class Person
	{
		//instance variable
		public string FirstName;
		public string LastName;
		public string city;
		public string state;
		public string email;
		public string phoneNumber;

		//parameterized constructor for initializing instance member
		public Person(string firstName, string lastName, string city, string state, string email, string phoneNumber)//Parameterized Constructor
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.city = city;
			this.state = state;
			this.email = email;
			this.phoneNumber = phoneNumber;
		}
		public String getFirstName() /// get method returns the value of the variable FirstName.
		{
			return FirstName;
		}

		public void setFirstName(String firstName)  // set method assigns a value to the name variable.
		{
			this.FirstName = firstName;
		}

		public String getLastName() //get method returns the value of the variable LastName.
		{
			return LastName;
		}

		public void setLastName(String lastName) //set method assigns a value to the name variable.
		{
			this.LastName = lastName;
		}

		public String getCity()//get method returns the value of the variable city.
		{
			return city;
		}

		public void setCity(String city)//get method returns the value of the variable city.
		{
			this.city = city;
		}

		public String getState()
		{
			return state;
		}

		public void setState(String state)
		{
			this.state = state;
		}
		public String getPhoneNumber()
		{
			return phoneNumber;
		}

		public void setPhoneNumber(String phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public String getEmail()
		{
			return email;
		}

		public void setEmail(String email)
		{
			this.email = email;
		}
	}
}
