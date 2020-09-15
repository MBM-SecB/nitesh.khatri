namespace LearningClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        //default constructor - parameter less
        public Country()
        {

        }

        //parameterized constructor
        public Country(string name)
        {
            Name = name;
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country = new Country();
            Country country1 = new Country("Nepal");
        }
    }
}