public class Professor
{
    public string profName { get; set; }
    public string classTeach { get; set; }
    private double salary;

    // Default constructor - I was getting compiler errors, chat gpt helped me solve
    public Professor(){
        profName = "";
        classTeach = "";
    }
    // End of compiler solution from chat gpt
    public void SetSalary(double salaryAmount){
        salary = salaryAmount;
    }

    public double GetSalary(){
        return salary; // originally, errors for no return; chat gpt
    }
}

public class Student
{
    public string studentName { get; set; }
    public string classEnroll { get; set; }
    private double _studentGrade;

    // Default constructor - I was gettign compiler errors, chat gpt helped me solve
    public Student(){
        studentName = "";
        classEnroll = "";
    }
    // End of compiler solution from chapt gpt
    public void SetGrade(double newGrade){
        _studentGrade = newGrade;
    }

    public double GetGrade(){
        return _studentGrade; // originally, errors for no return; chat gpt
    }
}

public class Program
{
    public static void Main(string[] args){
        
        //PRINT CODING AND CALCS QUESTION 2
        
        Professor profA = new Professor { profName = "Alice", classTeach = "Java" };
        profA.SetSalary(9000);
        Professor profB = new Professor { profName = "Bob", classTeach = "Math" };
        profB.SetSalary(8000);

        Student studentA = new Student { studentName = "Lisa", classEnroll = "Java" };
        studentA.SetGrade(90);
        Student studentB = new Student { studentName = "Tom", classEnroll = "Math" };
        studentB.SetGrade(80);

        Console.WriteLine($"Professor {profA.profName} teaches {profA.classTeach}, and the salary is: {profA.GetSalary()}");
        Console.WriteLine($"Professor {profB.profName} teaches {profB.classTeach}, and the salary is: {profB.GetSalary()}");

        Console.WriteLine($"Student {studentA.studentName} enrolls {studentA.classEnroll}, and the grade is: {studentA.GetGrade()}");
        Console.WriteLine($"Student {studentB.studentName} enrolls {studentB.classEnroll}, and the grade is: {studentB.GetGrade()}");

        double salaryDifference = Math.Abs(profA.GetSalary() - profB.GetSalary());
        Console.WriteLine($"The salary difference between {profA.profName} and {profB.profName} is: {salaryDifference}");

        double totalGrade = studentA.GetGrade() + studentB.GetGrade();
        Console.WriteLine($"The total grade of {studentA.studentName} and {studentB.studentName} is: {totalGrade}");
    }
}