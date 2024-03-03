namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1428;
            double area, r;

            Console.WriteLine("r = ");
            r = Convert.ToDouble(Console.ReadLine());

            area = pi * r * r;
            Console.WriteLine($"for r = {r}, area={area} ");
            Console.Read();
        }
    }
}