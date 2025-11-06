namespace Week2Workshop
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //task 1
            String userName = "Shristi";
            int luckyNumber = 5;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            //task 2 (1st process)
            const double PI = 3.14;
            double radius = 7.0;
            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;
            Console.WriteLine($"For a circle with radius {radius}:");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");

            //task 2 (2nd process)
            Circle circle = new Circle();
            Console.WriteLine($"Area: {circle.CalculateArea(7)}");
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter(7)}");

            //task 3
            byte b = 5;
            short s = 30000;
            int i = 6;
            long l = 7L;
            float f = 5.5f;
            double d = 19.99;
            decimal dec = 99.99m;
            char c = 'A';
            bool isTrue = true;

            int num = 55;
            string numString = num.ToString();

            string str = "3.14";
            double strDouble = Convert.ToDouble(str);

            Console.WriteLine($"Byte: {b}");
            Console.WriteLine($"Short: {s}");
            Console.WriteLine($"Int: {i}");
            Console.WriteLine($"Long: {l}");
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Decimal: {dec}");
            Console.WriteLine($"Char: {c}");
            Console.WriteLine($"Bool: {isTrue}");
            Console.WriteLine($"Int to string: {numString}");
            Console.WriteLine($"String to double: {strDouble}");

            //task 4
            int[] favNum = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Favorite numbers:");
            for (int j = 0; j<favNum.Length; j++)
            {
                Console.Write(favNum[j] + "");
            }
            Array.Sort(favNum);
            Console.WriteLine("\nSorted favorite numbers in ascending order:");
            for(int j = 0; j<favNum.Length; j++)
            {
                Console.Write(favNum[j] + "");
            }

            Array.Reverse(favNum);
            Console.WriteLine("\nReversed favourite number: ");
            for (int j = 0; j<favNum.Length; j++)
            {
                Console.Write(favNum[j] + "");
            }

            int searchNum = 5;
            int index = Array.IndexOf(favNum, searchNum);
            if (index >= 0)
                Console.WriteLine($"\nNumber {searchNum} found at index {index}.");
            else
                Console.WriteLine($"\nNumber {searchNum} not found in array.");

            //task 5
            DateTime birthDate = new DateTime(2005, 01, 15);
            DateTime currentDate = DateTime.Now;

            TimeSpan currenAge = currentDate - birthDate;

            double totalDays = currenAge.TotalDays;

            int years = (int)(totalDays / 365);

            Console.WriteLine($"My Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate}");
            Console.WriteLine($"My age: {years} years");

            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"10 days after my birth date: {newDate.ToShortDateString()}");

            //Task 6
            List<string> fruits = new List<string>() { "Mango", "Apple", "Pineapple" };
            fruits.Add("Strawberry");

            fruits.Remove("Apple");

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
            {
                {1, "Mango"},
                {2, "Pineapple"},
                {3, "Strawberry"}
            };


            fruitDictionary.Add(4, "Grapes");

            foreach (KeyValuePair<int, string> kvp in fruitDictionary)
            {
                Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
            }
        }
        //task 2 (2nd process)
        public class Circle
        {
            public const double PI = 3.14;
            public double CalculateArea(double radius)
            {
                return PI * radius * radius;
            }
            public double CalculatePerimeter(double radius)
            {
                return 2 * PI * radius;
            }
        }
    }   
}
