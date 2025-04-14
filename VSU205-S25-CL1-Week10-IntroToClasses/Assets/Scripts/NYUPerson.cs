    public class NYUPerson
    {
        public string netID;
        public string name;
        public long nNumber; //int but with more spaces
        public float age;

        //Default or empty constructor - you need an empty one if you want to
        // be able to use the constructor outside without having erorrs in the other code because
        //its going to look for the arguments
        public NYUPerson()
        {
            
        }

        //constructor that takes arguments 
        public NYUPerson(string netID, string name, long nNumber, float age)
        {
            this.name = name;
            this.netID = netID;
            this.nNumber = nNumber;
            this.age = age;
            
        }

        public virtual string GetRecord()
        {
            string result = "Name: " + name + "\n" +
                            "NetID: " + netID + "\n" +
                            "Age: " + age + "\n" +
                            "N Number: " + nNumber + "\n";
            return result;
        }
        
        
    }
