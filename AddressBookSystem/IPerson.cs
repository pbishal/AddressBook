using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    interface IPerson
    {
        void addPerson();
        void displayPerson();
        void editPerson();
        void deletePerson();
    }
}
