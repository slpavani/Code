using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{ 
    public partial class Form1 : Form
    {
        private Contact[] PhoneBook = new Contact[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Read( )
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            string line;
            PhoneBook=new Contact[Convert.ToInt32(sr.ReadLine())];
            for  (int i=0;(line = sr.ReadLine()) != null;i++)
            {
                string[] phonebook = line.Split(',');
                PhoneBook[i] = new Contact();
                PhoneBook[i].FirstName = phonebook[0];
                PhoneBook[i].LastName = phonebook[1];
                PhoneBook[i].Phone = phonebook[2];
            }
            sr.Close();
        }

        private void Display()
        {
            ContactList.Items.Clear();
            ContactList.Items.Add("Contact List");
            ContactList.Items.Add("************");
            for (int i = 0; i < PhoneBook.Length; i++)
            {
                ContactList.Items.Add(PhoneBook[i].ToString());

            }
        }

        private void clearForm()
        {
            firstNameText.Text= string.Empty;
            lastNameText.Text = string.Empty;
            phoneText.Text = string.Empty;
        }
        private void Write(Contact obj)
         {
            StreamWriter sw = new StreamWriter("Contacts.txt");
            sw.WriteLine(PhoneBook.Length+1);
            for (int i = 0; i < PhoneBook.Length; i++)
            {
                //sw.WriteLine(PhoneBook[i].FirstName);
                //sw.WriteLine(PhoneBook[i].LastName);
                //sw.WriteLine(PhoneBook[i].Phone);
                sw.WriteLine(PhoneBook[i].FirstName+","+PhoneBook[i].LastName+","+PhoneBook[i].Phone);
            }
            //sw.WriteLine(obj.FirstName);
            //sw.WriteLine(obj.LastName);
            //sw.WriteLine(obj.Phone);
            sw.WriteLine(obj.FirstName+","+obj.LastName+","+obj.Phone);
           
            sw.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = firstNameText.Text;
            contact.LastName = lastNameText.Text;
            contact.Phone = phoneText.Text;
           // ContactList.Items.Add(contact.ToString());

            Write(contact);
            Read();
            sortContacts();
            Display();
            clearForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            sortContacts();
            Display();
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sort(object sender, EventArgs e)
        {
            sortContacts();
        }

        private void sortContacts()
        {
            Contact temp;
            bool swap;
            do
            {
                swap = false;
                for (int x = 0; x < (PhoneBook.Length - 1); x++)
                {
                    if (PhoneBook[x].FirstName.CompareTo(PhoneBook[x + 1].FirstName) > 0)
                    {
                        temp = PhoneBook[x];
                        PhoneBook[x] = PhoneBook[x + 1];
                        PhoneBook[x + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);
        }
    }
}
