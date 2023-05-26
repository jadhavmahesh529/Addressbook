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
                }
        
            }
        }
    }
}
