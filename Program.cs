namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber, gradYear;
            double price;
            string course, name;

            roomNumber = 29;
            price = 2.99;
            course = "Computer Science";
            name = "Josh Campeau";
            gradYear = 2026;

            Console.WriteLine("This is room # " + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning " + course);
            Console.WriteLine();   
            Console.WriteLine("My name is " + name + " and I graduate in " + gradYear);

        }
    }
}
