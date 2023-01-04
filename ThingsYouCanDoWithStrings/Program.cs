using System.Runtime.CompilerServices;

class Program
{
    private static void Main(string[] args)
    {
        UsingArray();
    }
    private static void UsingArray()
    {
        // creating an array
        string[] arr = new string[10];
        arr[0] = "Hello";
        arr[1] = "Mate";
        arr[2] = "!";
        Console.WriteLine(arr[0] + " " + arr[1] + arr[2]);

    }
}


