class Properties
{
    int age = 23;
    string name = "Nitesh";

    public string Name {get; set;}

    //read only
    public string Address {get;}

    public int Age {
        get
        {
            return age;
        }
        set
        {
            if(value > 20 && value < 30)
            {
                age = value;
            }
        }
    }
}