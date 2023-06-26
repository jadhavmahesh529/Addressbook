namespace Basicdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook Addressbook = new Addressbook();
            while (true)
            {
                Console.WriteLine("select \n1)create contact\n2)display\n3)edit contact");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Addressbook.AddContact();
                        break;
                    case 2:
                        Addressbook.Display();
                        break;
                    case 3:
                        Addressbook.Editcontact();
                        break;
                    case 4:
                        Addressbook.DeleteContactUsingName();
                        break;
                    case 5:
                        Console.WriteLine("Enter city or state to search:");
                        string cityOrState = Console.ReadLine();
                        List<Contact> searchResults = Addressbook.SearchByCityOrState(cityOrState);

                        if (searchResults.Count > 0)
                        {
                            Console.WriteLine("Search results:");
                            foreach (var contact in searchResults)
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
                        else
                        {
                            Console.WriteLine("No contacts found in the specified city or state.");
                        }

                        break;


                }
            }
        }
        
            
        
    }
}
