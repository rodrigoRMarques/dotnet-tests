public class Class
{

    private static string result;

    public static void Main()
    {
        SaySomething();
        Console.WriteLine(result);
        
        Task.Run(async () => await SaySomething()).Wait();
        Console.WriteLine(result);
    }

    static async Task<string> SaySomething()
    {
        await Task.Delay(5);
        result = "Hello world!";
        return "Something";
    }
}