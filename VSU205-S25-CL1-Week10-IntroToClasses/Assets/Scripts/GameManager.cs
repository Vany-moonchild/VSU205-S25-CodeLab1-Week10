using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NYUPerson mattParker = new NYUStaff();
        mattParker.name = "Matt Parker";
        mattParker.nNumber = 394839525;
        mattParker.netID = "mp612";
        mattParker.age = 42;

        Debug.Log(mattParker.GetRecord());
        
        NYUGradStudent vany = new NYUGradStudent();
        vany.name = "Vany Usman";
        vany.nNumber = 112025673;
        vany.netID = "vsu205";
        vany.age = 23;
        vany.gradYear = 2026; //casting from NYUStudent 
        vany.totalSemesters = 4;
        // ((NYUStaff)vany).salary = 10345;
        
        
        
        
        
        Debug.Log(vany.GetRecord());
        
        NYUPerson Frank = new NYUPerson("f42", "Frank", 125325234, 40);
        
        Debug.Log(Frank.GetRecord());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
