namespace MyLibrary
{
    public class PercentChecker
    {
        public double[] Percents { get; set; } = Array.Empty<double>();

        public bool CheckSum(double precision)
        {
            double sum = 0;
            foreach (double p in Percents)
                sum += p;

            return Math.Abs(sum - 100) <= precision;
        }
    }
}
