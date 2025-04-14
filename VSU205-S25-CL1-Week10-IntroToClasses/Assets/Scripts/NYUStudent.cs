using UnityEngine;

public class NYUStudent : NYUPerson
{
    public int gradYear;


    public NYUStudent()
    {
        
    }

    public NYUStudent(string netID, string name, long nNumber, 
        float age, int gradYear) : base(netID, name, nNumber, age)
    {
        this.gradYear = gradYear;
    }
}
