using System.Net.Cache;
using System.Threading.Channels;

public class Lecture
{
    public static void Main(string[] args)
    {
        int age = 20;
        Console.WriteLine(age);
        double PI = Math.PI;
        Console.WriteLine(PI);
        bool enable = true;
        string name = "Bang";


        // Sum
        int number1 = 10;
        int number2 = 12;
        int number3, number4, number5;

        int sum = number1 + number2;

        Console.WriteLine("Sum of " + number1 + " and " + number2 + ": " + sum);


        //
        float floatNumber1 = 1.2f;
        float floatNumber2 = 1.3f;

        float sumFloat = floatNumber1 + floatNumber2;
        float divFloat = floatNumber1 / floatNumber2;
        float multiFloat = floatNumber1 * floatNumber2;

        Console.WriteLine("Sum of " + floatNumber1 + " and " + floatNumber2 + ": " + sumFloat);
        Console.WriteLine("Division of " + floatNumber1 + " for " + floatNumber2 + ": " + divFloat);
        Console.WriteLine("Multiple of " + floatNumber1 + " for " + floatNumber2 + ": " + multiFloat);


        Console.Read();

    }
}