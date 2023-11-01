namespace Homework9;
class Student{
    private int studentID;
    private string studentName;

    public Student(int id, string name){
        studentID = id;
        studentName = name;
        StudentList.Add(this);
    }

    public string StudentName{
        get { return studentName; }
    }

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> StudentList = new List<Student>();
}

class Program{
    static void Main(){
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>{
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        // #4 adding Tom to the gradebook with 3.3 GPA; I asked Chat GPT about this and this is the result. 
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

       
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values){
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        // #6, I asked Chat GPT to verify my code, as I was getting long error. This is corrected version. 
        foreach (var student in Student.StudentList)
        {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
