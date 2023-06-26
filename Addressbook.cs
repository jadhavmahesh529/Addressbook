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
        Dictionary<string, List<Contact>> contactsByCity = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> contactsByState = new Dictionary<string, List<Contact>>();

        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine()!;
            Console.WriteLine("Enter Lasttname");
            contact.Lastname = Console.ReadLine()!;
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine()!;
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine()!;
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine()!;
            Console.WriteLine("Enter Zip");
            contact.Zip = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contact.Phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter email");
            contact.email = Console.ReadLine()!;


            con.Add(contact);
            AddToDictionary(contact.City, contact, contactsByCity);
            AddToDictionary(contact.State, contact, contactsByState);

        }
        public void Display()
        {
            foreach (var contact in con)
            {
                Console.WriteLine("Firstname--" + contact.Firstname);
                Console.WriteLine("Lastname--" + contact.Lastname);
                Console.WriteLine("Address--" + contact.Address);
                Console.WriteLine("City--" + contact.City);
                Console.WriteLine("State--" + contact.State);
                Console.WriteLine("Zip--" + contact.Zip);
                Console.WriteLine("Phonenumber--" + contact.Phonenumber);
                Console.WriteLine("email--" + contact.email);
                Console.WriteLine();
            }

        }

        public void Editcontact()
        {
            Console.WriteLine("to edit contact list enter firstname");
            string name = Console.ReadLine();
            foreach (var data in con)
            {
                if (con.Contains(data))
                {
                    if (data.Firstname == name)
                    {
                        Console.WriteLine("name is exits");
                        Console.WriteLine("to edit contact\n1)Lastname\n2)Address\n3)City\n4)State\n5)Zip\n6)Phonenumber\n7)email");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("enter new lastname");
                                string lastname = Console.ReadLine();
                                data.Lastname = lastname;
                                break;
                            case 2:
                                Console.WriteLine("enter new address");
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                Console.WriteLine("enter new city");
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                Console.WriteLine("enter new state");
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                Console.WriteLine("enter new zip");
                                int zip = Convert.ToInt32(Console.ReadLine());
                                data.Zip = zip;
                                break;
                            case 6:
                                Console.WriteLine("enter new phonenumber");
                                int phonenumber = Convert.ToInt32(Console.ReadLine());
                                data.Phonenumber = phonenumber;
                                break;
                            case 7:
                                Console.WriteLine("enter new email");
                                string email = Console.ReadLine();
                                data.email = email;
                                break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("name does not exits");
                    }
                }
            }



        }
        public void DeleteContactUsingName()
        {
            Console.WriteLine("Enter the first name of the contact to delete:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact to delete:");
            string lastName = Console.ReadLine();
            Contact person = null;
            foreach (var data in con)
            {
                if (data.Firstname.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    data.Lastname.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    person = data;
                    break;
                }
            }
            if (person != null)
            {
                con.Remove(person);
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not found");
            }

        }
        public List<Contact> SearchByCityOrState(string cityOrState)
        {
            List<Contact> searchResults = con.FindAll(contact =>
                contact.City.Equals(cityOrState, StringComparison.OrdinalIgnoreCase) ||
                contact.State.Equals(cityOrState, StringComparison.OrdinalIgnoreCase));

            return searchResults;
        }
        public List<Contact> GetContactsByCity(string city) => contactsByCity.TryGetValue(city, out var contactsInCity) ? contactsInCity : new List<Contact>();

        public List<Contact> GetContactsByState(string state) => contactsByState.TryGetValue(state, out var contactsInState) ? contactsInState : new List<Contact>();

        private void AddToDictionary(string key, Contact contact, Dictionary<string, List<Contact>> dictionary)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key].Add(contact);
            }
            else
            {
                dictionary[key] = new List<Contact> { contact };
            }

        }
        public int GetContactCountByCity(string city)
        {
            return contactsByCity.Values.SelectMany(list => list)
                                        .Count(contact => contact.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        public int GetContactCountByState(string state)
        {
            return contactsByState.Values.SelectMany(list => list)
                                        .Count(contact => contact.State.Equals(state, StringComparison.OrdinalIgnoreCase));
        }

    }

}
