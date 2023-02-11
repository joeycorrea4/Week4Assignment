namespace Week4Assignment
{
   
 
class Rectangle
    {

        // Utility function
        static int areaRectangle(int a, int b)
        {
            int area = a * b;
            return area;
        }

        static int perimeterRectangle(int a, int b)
        {
            int perimeter = 2 * (a + b);
            return perimeter;
        }

        // Driver Function
        public static void Main()
        {

            int a = 3;
            int b = 10;
            Console.WriteLine("Length: " + a);
            Console.WriteLine("Width: " + b);
            Console.WriteLine("Area: "
                          + areaRectangle(a, b));
            Console.WriteLine("Perimeter: "
                     + perimeterRectangle(a, b));
        }
    }
}
