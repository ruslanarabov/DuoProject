namespace MiniDuoTask.Models;

public class Group
{
    private static int _id;
    public int Id { get; set; }
    public string Name { get; set; } 
    public int Capacity { get; set; } 

    public Group(string name, int capacity)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new NullReferenceException("Group name cannot be null or empty.");
        }
        Name = name;
        Capacity = capacity;
        Id = ++_id;
    }
}