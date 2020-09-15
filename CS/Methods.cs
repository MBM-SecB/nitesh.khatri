using System;


public class Methods
{
    //takes 2 argument and return value
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }

    public void Multiply<T>(T firstNum, T secondNum)
    {
        
    }

    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach(int num in numbers)
        {
            product = product * num;
        }
        return product;
    }

    //named argument
    internal void PrintCustomerdetail(string name, byte age, string address, DateTime dob)
    {
    //string interpolation here:
    Console.Write($"Customer Details: {name}, {age}, {address}, {dob}");
    }

    //returning multiple value
    (int, string) Dosomething(int x)
    {
        //do something on x
        return (343, "");
    }

    //returning max and min value of supplied numbers
    internal (int, int) FindMinMax(params int[] numbers)
    {
        int min = numbers[0], max = numbers[0];
        foreach(int num in numbers)
        {
            if(num < min)
                min = num;
            if(num > max)
                max = num;
        }
        return(max, min);
    }
}


public class MethodTester
{
    void TestMethods()
    {
        Methods methods = new Methods();
        int product = methods.Multiply (1234, 4321);
        methods.Multiply<decimal>(234.54m, 34235453.4234234m);

        product = methods.Multiply (1234, 4321);
        product = methods.Multiply (1234, 4321, 3234, 23132, 232133, 323133, 311);

        // methods.PrintCustomerdetail(dob: DateTime.Now, name:"Nitesh", age: 21, address:"Bhaktapur");

        //tuple
        //var
        (int, int) result = methods.FindMinMax(1,34,2,23,45,21,3,56,52,78,98,71);

        // Console.WriteLine($"Minimum: {result.Min}, Maximum {result.Max}");
    }
}
