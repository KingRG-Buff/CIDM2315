namespace HomeWorkWk5;
class Program
{
    static void Main(string[] args)
    {
        /*
        //Question 1: Two integers, larger result printed

        Console.WriteLine("Enter a number:");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        int b = Convert.ToInt16(Console.ReadLine());

        int greater = a;

        if (b > greater)
        {
            greater = b;
        }

        Console.WriteLine($"a={a}; b={b}");
        Console.WriteLine($"The largest number is: {greater}”);

        Console.ReadLine(); */ 

        /*
        //Question 2: Four integers, larger result printed

        Console.WriteLine("Enter a number:");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        int b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter a third number:");
        int c = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter a fourth number:");
        int d = Convert.ToInt16(Console.ReadLine());

        int greatest = a;

        if (b > greatest){
            greatest = b;
        }

        if (c > greatest){
            greatest = c;
        }

        if (d > greatest){
            greatest = d;
        }
        Console.WriteLine($"a={a}; b={b}; c={c}; d={d}");
        Console.WriteLine($"The largest number is: {greatest}");
        Console.ReadLine(); */

        /*
        //Question 3: Account set up and verification

        static bool CheckAge(int birthYear)
        {
        int age = 2023 - birthYear;
            return age >= 18;
        }
        static void Main()
        static void CreateAccount()
        {
        Console.WriteLine("Input Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Input Password:");
        string password = Console.ReadLine();

        Console.WriteLine("Verify Password:");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine("Input Birth Year:");
        string birthYearInput = Console.ReadLine();
        int birthYear;

        if (int.TryParse(birthYearInput, out birthYear))
        {
            if (CheckAge(birthYear))
            {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
            }
            else
            {
            Console.WriteLine("Could not create an account");
            }
        }
            else
            {
            Console.WriteLine("Invalid birth year input");
            }
        }
        */

    }
}