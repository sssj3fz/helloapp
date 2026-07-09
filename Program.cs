namespace HelloApp;

class Program
{
    static void Main(string[] args)
    {
        SayHello();
        SayHelloWhite();
        SayHelloBlack();
    }

    static void SayHello()
    {
        Console.WriteLine("hello everyone");
    }

    static void SayHelloWhite()
    {
        Console.WriteLine("hello white");
    }

    static void SayHelloBlack()
    {
        Console.WriteLine("hello black");
    }
}