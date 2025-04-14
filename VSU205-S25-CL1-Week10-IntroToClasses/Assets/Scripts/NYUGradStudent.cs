
public class NYUGradStudent : NYUStudent
{

    public int totalSemesters;


    public NYUGradStudent()
    {
        
    }

    public NYUGradStudent(string netID, string name, long nNumber, float age, int gradYear, int totalSemesters) : base(netID, name, nNumber, age, gradYear)
    {
        this.totalSemesters = totalSemesters;
    }
}
