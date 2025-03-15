
namespace csharp_studies.variables;

public class Variables_studies
{
    public static void Main()
    {
        string myName = "Thaynara Dutra";

        int number = 10;
        number = 1;

        myName = myName + number;

        char character = 'a';

        bool boolean = false;

        var variable = 500;
        variable = 1;

        dynamic var = 1;
        var = "test";


        Console.WriteLine(myName); //output Thaynara Dutra1

        Console.WriteLine(number); //output 1

        Console.WriteLine(character); //output a

        Console.WriteLine(boolean); //output False

        Console.WriteLine(variable); //output 1

        Console.WriteLine(var); //output Test

    }
}



