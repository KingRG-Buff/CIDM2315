public class Customer
{
    private int cus_id;
    public string cus_name {get; set;}
    public int cus_age {get; set;}

    public Customer(int id, string name, int age){
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }
    // I asked Chat GPT how to update the ID, and this method was provided
    // Just enter the new ID directly into the paranthesis with ChangeID
    public void ChangeID(int new_id){
        cus_id = new_id;
    }

    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer){
        if (cus_age > objCustomer.cus_age){
            Console.WriteLine($"{cus_name} is older");
        }
        else if (cus_age < objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        else{
            Console.WriteLine($"{cus_name} and {objCustomer.cus_name} are of the same age");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Customer alice = new Customer(110, "Alice", 28);
        Customer bob = new Customer(111, "Bob", 30);
        // I asked Chat GPT how to update the id, and this method was provided
        // just enter the new id directly into the parenthesis with ChageID
        alice.PrintCusInfo();
        bob.PrintCusInfo();
        alice.ChangeID(220);
        bob.ChangeID(221);
        alice.PrintCusInfo();
        bob.PrintCusInfo();
        alice.CompareAge(bob);
    }
}