// See https://aka.ms/new-console-template for more information
namespace Assignment_0_MTL
{
    internal class program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Program 0");

            CPU Intel1 = new CPU("i9 9000k", 3000, "2011-5", 150);
            CPU Intel2 = new CPU("i7-8000k", 4000, "2012-8", 250);
            CPU Intel3 = new CPU("i13-1300k", 4500, "2015-9", 300);

            Laptop Laptop1 = new Laptop("2011 Model", Intel1, 150);
            Laptop Laptop2 = new Laptop("2011 Model", Intel1, 150);
            Laptop Laptop3 = new Laptop("2012 Model", Intel2, 250);
            Laptop Laptop4 = new Laptop("2015 Model", Intel3, 300);
            
        }
    }
}
