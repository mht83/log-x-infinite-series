namespace log_x__infinite_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x (0 < x ≤ 2): ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= 0 || x > 2)
            {
                Console.WriteLine("The value of x must be between 0 and 2 (0 < x ≤ 2).");
                return;
            }

            Console.Write("Enter the number of terms to calculate: ");
            int numTerms = Convert.ToInt32(Console.ReadLine());

            double logX = CalculateLogX(x, numTerms);
            Console.WriteLine($"The value of log({x}) up to {numTerms} terms is: {logX}");
        }
        public static double CalculateLogX(double x, int numTerms)
        {
            double logX = 0;
            for (int n = 1; n <= numTerms; n++)
            {
                double term = Math.Pow(-1, n + 1) * Math.Pow(x - 1, n) / n;
                logX += term;
            }
            return logX;
        }
    }
}
