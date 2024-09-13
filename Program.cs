namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber, gradYear;
            double price, radius, areaCircle, areaTriangle, triangleBase, triangleHeight;
            string course, name;
          

            roomNumber = 29;
            price = 2.99;
            course = "Computer Science";
            name = "Josh Campeau";
            gradYear = 2026;
            radius = 6;
            triangleBase = 6;
            triangleHeight = 3;
            areaCircle = Math.PI * (radius * radius);
            areaCircle = Math.Round(areaCircle, 1);
            areaTriangle = (triangleBase * triangleHeight) / 2;
            areaTriangle = Math.Round(areaTriangle, 1);


            Console.WriteLine("This is room # " + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning " + course);
            Console.WriteLine();   
            Console.WriteLine("My name is " + name + " and I graduate in " + gradYear);
            Console.WriteLine();
            Console.WriteLine("The area of a circle with a radius of " + radius + " would be " + areaCircle);
            Console.WriteLine();
            Console.WriteLine("The area of a triangle with a base of 6cm and a height of 3cm would be " + areaTriangle + "cm");



        }
    }
}
