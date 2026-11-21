namespace MyLibrary
{
    /// <summary>
    /// Задание 2. Метод получает одномерный массив вещественных чисел
    /// (процентные доли) и заданную точность. Определяет, составит ли
    /// сумма процентов 100 с учётом заданной точности.
    /// </summary>
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
