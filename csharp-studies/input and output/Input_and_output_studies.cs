namespace csharp_studies;

public class Input_and_output_studies
{
    public static void Main()
    {
        Console.WriteLine("--------Sign Up--------");

        //username
        Console.WriteLine("Entry your name: ");
        string name = Console.ReadLine();

        //user age
        Console.WriteLine("Entry your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------");

        Console.WriteLine("Username: " + name);
        Console.WriteLine("Age: " + age);
    }
}
