using Basicdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basicdemo
{
    internal class Addressbook
    {
        List<Contact> con = new List<Contact>();    
        public void AddContact()

        {
            Contact contact = new Contact();


            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter city");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            contact.Phonenumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.email = Console.ReadLine();

            con.Add(contact);
        }

        public void Display()
        {
            foreach (Contact contact in con)
            {
                Console.WriteLine("Firstname-"+contact.Firstname);
                Console.WriteLine("Lastname-"+contact.Lastname);
                Console.WriteLine("Address-"+contact.Address);
                Console.WriteLine("City-"+contact.city);
                Console.WriteLine("State-"+contact.State);
                Console.WriteLine("Zip-" + contact.Zip);
                Console.WriteLine("Phonenumber-"+contact.Phonenumber);
                Console.WriteLine("email-"+contact.email);
            }
        }

        internal void Editcontact()
        {
            throw new NotImplementedException();
        }
    }    
         
}
