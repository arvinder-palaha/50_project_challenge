namespace SimplifiedFraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string Simplify(string fraction)
        {
            var parts = fraction.Split('/');
            var numerator = int.Parse(parts[0]);
            var denominator = int.Parse(parts[1]);

            if (numerator > denominator)
            {
                return $"{numerator / denominator}";
            }

            var gcd = GCD(numerator, denominator);

            return $"{numerator / gcd}/{denominator / gcd}";
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return GCD(b, a % b);
        }
    }
}

