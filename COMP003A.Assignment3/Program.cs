namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Academic & Personal Readiness Evaluator ------\n");

            int currentYear = DateTime.Now.Year;
            Console.WriteLine($"Current Year: {currentYear}");

            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse( Console.ReadLine() );
            int age = currentYear - birthYear;


            Console.WriteLine($"Calculated Age: {age}");

            if ( age < 0)
            {
                Console.WriteLine("Readiness Category: Unknown due to invalid age");
            }
            else if ( age < 18)
            {
                Console.WriteLine("Readiness Category: Minor");
            }
            else
            {
                Console.WriteLine("Readiness Category: Adult");
            }



        }
    }
}
