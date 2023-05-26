namespace Basicdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Addressbook a = new Addressbook();
            while (true)

            {
                Console.WriteLine("select\n1)Create Contact\n2");
                int option = Convert.ToInt32(Console.ReadLine());




                switch (option)
                {
                    case 1:
                        a.AddContact();
                        break;

                    case 2:
                        a.Display();
                        break;



                }
            }
        }
    }
}
