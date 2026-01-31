namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Academic Readiness Evaluator ------\n");

            int currentYear = DateTime.Now.Year;
            Console.WriteLine($"Current Year: {currentYear}");

            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse( Console.ReadLine() );


        }
    }
}
