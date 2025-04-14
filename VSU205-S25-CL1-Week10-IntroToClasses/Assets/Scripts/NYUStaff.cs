using UnityEngine;

public class NYUStaff : NYUPerson
{
    public float salary;

    public NYUStaff()
    {
        
    }

    public NYUStaff(string netID, string name, 
        long nNumber, float age, float salary) : base(netID, name, nNumber, age)
    {
        this.salary = salary;
    }

    public override string GetRecord()
    {
        //return "WTF";
        string result = base.GetRecord();
        
        result += "\nSalary: " + salary;
        
        return result;
    }
    
}
