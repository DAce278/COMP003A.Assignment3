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


            Console.Write("\nDo you have a valid ID? (yes/no): ");
            string idResponse = Console.ReadLine();
            bool idStatus = (idResponse.ToLower() == "yes");


            Console.Write("Have you completed orientation? (yes/no): ");
            string orientationResponse = Console.ReadLine();
            bool orientationStatus = (orientationResponse.ToLower() == "yes");


            if (age < 0)
            {
                Console.WriteLine("\nReadiness Status: Unknown due to invalid age");
            }
            else if (age < 18 || idStatus == false)
            {
                Console.WriteLine("\nReadiness Status: Not Ready");
            }
            else if (orientationStatus == false)
            {
                Console.WriteLine("\nReadiness Status: Conditionally Ready");
            }
            else
            {
                Console.WriteLine("\nReadiness Status: Ready");
            }


            Console.Write("Select a guidance plan:" +
                        "\n1 - Academic Planning" +
                        "\n2 - Financial Planning" +
                        "\n3 - Career Planning" +
                        "\nEnter choice: ");

            string planChoice = Console.ReadLine();

            switch ( planChoice)
            {
                case "1":
                    Console.WriteLine("Guidance:\nMeet with an academic advisor to plan your next term.");
                    break;

                case "2":
                    Console.WriteLine("Guidance:\nMeet with a financial advisor.");
                    break;

                case "3":
                    Console.WriteLine("Guidance:\nMeet with a career counselor for future direction.");
                    break;

                default:
                    Console.WriteLine("Invalid response");
                    break;
            }
        }
    }
}
