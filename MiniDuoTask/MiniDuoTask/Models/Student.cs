namespace MiniDuoTask.Models;

public class Student
{
    private static int _id = 0;
    public int ID { get; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
    public Group Group { get; set; }

    public Student(int id, string fullName, int age, double grade, Group group)
    {
        if (string.IsNullOrEmpty(fullName))
        {
            throw new Exception("FullName is required");
        }
    }
    
}