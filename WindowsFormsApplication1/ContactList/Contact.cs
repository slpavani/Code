using System;

namespace ContactList
{
    class Contact
    {
        private string firstname;
        private string lastname;
        private string phone;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if(value.Length ==10)
                phone = value;
                else
                {
                    phone = "7894561230";
                }
            }
        }

        public Contact()
        {
            FirstName = "Pavani";
            LastName = "Sikhakolli";
            Phone = "7787076022";
        }

        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += string.Format("{0} , {1} ", FirstName, LastName);
            output += string.Format("({0}) {1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 3),
                Phone.Substring(6, 4));
            return output;

        }
    }
}

