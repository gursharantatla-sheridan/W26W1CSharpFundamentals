namespace W26W1CSharpFundamentals
{
    internal class Program
    {
        static int z;

        static void Main(string[] args)
        {
            int @double = 5;

            //int i = 5;
            Console.WriteLine(z);

            double d = 5.5;

            float f = 5.5F;
            decimal m = 5.5M;
            long l = 3454353L;

            var n = 5;
            //n = "John";


            Console.WriteLine(@"Hello ""x"" world");

            int a = 3, b = 6, c = 7;

            // string concatenation
            Console.WriteLine("a = " + a + " b = " + b + " c = " + c);

            // string interpolation
            Console.WriteLine($"a = {a} b = {b} c = {c}");
            Console.WriteLine("\n\n");


            // value type
            int i = 5;
            int j = i;

            i = i + 10;
            Console.WriteLine(j);
            Console.WriteLine("\n");
            
            // reference type
            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);
            c1.radius = 30;
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            //Circle c2 = new Circle();
            c2.radius = 100;

            Console.WriteLine(c1.radius);
            Console.WriteLine("\n\n");



            // string examples
            string s1 = "hello";
            string s2 = s1;

            s2 = "bye";
            Console.WriteLine(s1);
            Console.WriteLine("\n\n");



            // output formatting using ToString()
            double amount = 2343245.21832;
            Console.WriteLine(amount.ToString("C"));

            double discount = 0.25;
            Console.WriteLine(discount.ToString("P0"));

            double num = 34536546.532732;
            Console.WriteLine(num.ToString("F3"));


            int? aa = null;

            //int aaaa = amount as int;

            Console.Write("Enter subtotal: ");
            double subtotal = double.Parse(Console.ReadLine());
        }
    }

    class Circle
    {
        public int radius;
    }
}
