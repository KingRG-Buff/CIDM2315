namespace Wk3HomeWork;
class Program
{
    static void Main(string[] args)
    {
        //Homework Question 1

        /*
        Console.WriteLine("Enter a number: "); 

        int N = Convert.ToInt16(Console.ReadLine());
        
        int i = 2;
        for (i = 2; i < N; i++)
        {
            if (N % i == 0) //i had to google the calc for prime numbers in c#       
                break;
        }
        if (i == N)
        {
            Console.WriteLine($"{N} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{N} is not a prime number.");
        }
        */


        
        //Homework Question 2
        
        /*
        Console.WriteLine("Assign an int value to N:");
        
        int N = Convert.ToInt16(Console.ReadLine());

        //Referenced Wk. 3 Lecture Slide 29

        for (int row = 0; row < N; row++)
        {
            for (int  col = 0; row< N; col++)
            {
                Console.Write("#");
                if( col + 1 == N)
                    break; // had to correct my original code to include break
            }
            Console.WriteLine("");
        }
        */


        //Homework Question 3

        /*
        Console.WriteLine("Assign an int value to N:");
        
        int N = Convert.ToInt16(Console.ReadLine());

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                Console.Write("*"); //similar to Question 2

                if (col == row && col + 1 == N)
                    break; //this time i remembered the break!
            }
            Console.WriteLine("");
        }   
        */


        //BONUS QUESTION! 
        //Had to Write " " a space for right indent shape

        /*
         Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());

        for (int row = 1; row <= N; row++) 
            //Visual Studio alerted: Reverse 'for' statement! 
            //This corrected the shape!
        {
            for (int indent = 1; indent <= N - row; indent++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col <= row; col++)
            {
                Console.Write(row);

                if (row == N && col == row)
                    break;
            }

            Console.WriteLine();
        }
        */

    }
}
