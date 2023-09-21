namespace Wk4HomeWork;
class Program
{


    // Homework Question 1
    public static int numbers(int a, int b)

    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main(string[] args)   
    {
       Console.WriteLine("Enter a number:");
            int a = Convert.ToInt16(Console.ReadLine()); // Got errors: Partnered with my friend Mike to figure out this method

        Console.WriteLine("Enter another number:");
            int b = Convert.ToInt16(Console.ReadLine()); // Got errors: Partnered with my friend Mike to figure out this method
       
            int greater = numbers(a, b);
        
        Console.WriteLine($"a={a}; b={b}");
        Console.WriteLine($"The Largest Number Is: {greater}");
        
    }
}
    // Homework Question 2
    // Managed my time poorly today, could not figure it out timely :(
