using System;
public class EmployeeGenerator : IComparable
{
    Random rand = new Random();
    private int priority;
    private string name = "";
   public EmployeeGenerator()
    {
        this.priority = 0;
        this.name = "";
    }
    public int Priority
    {
        get { return priority; }
        set { priority = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        string employee = string.Format("Name: {0}, Priority: {1}", name, priority);
        return employee;
    }
    public int CompareTo(object obj)
    {
        EmployeeGenerator newEmp = obj as EmployeeGenerator;
        if (priority > newEmp.priority)
        {
            return 1;
        }
        else if (priority < newEmp.priority) 
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}