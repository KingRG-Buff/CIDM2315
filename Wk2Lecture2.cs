namespace Week2Lecture2;
class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Please input a value for x: ");
        string input_x = Console.ReadLine();
        int int_x= Convert.ToInt16(input_x);

        if(int_x %2==0){
            Console.WriteLine("x is even");
        }
        else{
            Console.WriteLine("x is odd");*/

        /*Console.WriteLine("Please input a value for x: ");
        if(int_x>0){
            Console.WriteLine("x is positive");
        }
        else if(int_x==0){
            Console.WriteLine("x is zero");
        }
        else{ // x <0
            Console.WriteLine("x is negative");*/
        
        int n1 = 10, n2 = 20, n3 = 30;
        if(n1>n2){
            if(n1>n3){
                Console.WriteLine("The largest num: n1");
            }
            else{ //n1<=n3
                Console.WriteLine("The largest num: n3");
            }
        }
        else{ //n2>=n1
            if(n2>n3){
                Console.WriteLine("The largest num: n2");
            }
            else{ //n3>n2
                Console.WriteLine("The largest num: n3");
            }
        }
    }
}
