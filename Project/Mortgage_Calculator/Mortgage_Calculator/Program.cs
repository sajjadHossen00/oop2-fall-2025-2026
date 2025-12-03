class Program
{
    static void Main()
    {
        double salary = 0;
        double creditScore = 0;
        bool criminalRecord = false;
        while (true)
        {
            Console.Write("Enter your monthly salary: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out salary))
                break;
            else
                Console.WriteLine("Please enter a numeric value.");
        }
        while (true)
        {
            Console.Write("Enter your credit score (0 - 500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Credit score must be between 0 and 500.");
            }
            else
            {
                Console.WriteLine("Please enter a numeric value between 0 and 500.");
            }
        }
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (input == "true")
            {
                criminalRecord = true;
                break;
            }
            else if (input == "false")
            {
                criminalRecord = false;
                break;
            }
            else
            {
                Console.WriteLine("Please type 'true' or 'false'.");
            }
        }
        bool eligible = (creditScore >= 300) && !criminalRecord;
        if (!eligible)
        {
            Console.WriteLine("\nSorry, you are not eligible for a loan.");
            Console.WriteLine("You must have a good credit score (≥ 300) and no criminal record.");
            return;
        }
        double principal = 0;
        while (true)
        {
            Console.Write("Enter your desired loan amount: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out principal))
            {
                if (principal <= 2 * salary)
                    break;
                else
                    Console.WriteLine("Loan request denied. Loan amount must be under 2 times your salary.");
            }
            else
            {
                Console.WriteLine(" Please enter a numeric value.");
            }
        }
        double annualInterestRate = 0;
        while (true)
        {
            Console.Write("Enter annual interest rate (in %): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out annualInterestRate))
                break;
            else
                Console.WriteLine("Please enter a numeric value.");
        }
        int years = 0;
        while (true)
        {
            Console.Write("Enter loan period in years: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(input, out years))
                break;
            else
                Console.WriteLine("Please enter a numeric value.");
        }

        double monthlyRate = annualInterestRate / 100 / 12;
        int numberOfPayments = years * 12;

     double mortgage = principal * (monthlyRate * Math.Pow(1 + monthlyRate, numberOfPayments)) /(Math.Pow(1 + monthlyRate, numberOfPayments) - 1);

        double totalPayment = mortgage * numberOfPayments;
        double totalInterest = totalPayment - principal;

        Console.WriteLine("\n====== Mortgage Summary ======");
        Console.WriteLine($"Monthly Salary: BDT {salary:0,0.00}");
        Console.WriteLine($"Credit Score: {creditScore}");
        Console.WriteLine($"Criminal Record: {criminalRecord}");
        Console.WriteLine($"Loan Amount: BDT {principal:0,0.00}");
        Console.WriteLine($"Annual Interest Rate: {annualInterestRate}%");
        Console.WriteLine($"Loan Period: {years} years");
        Console.WriteLine($"\nMonthly Payment: BDT {mortgage:0,0.00}");
        Console.WriteLine($"Total Payment: BDT {totalPayment:0,0.00}");
        Console.WriteLine($"Total Interest: BDT {totalInterest:0,0.00}");
        Console.WriteLine("------------------------------");
        Console.ReadKey();
    }
}
