namespace _25E2_4_TP1_Console.Exercicio6;

public class Logger
{
    public void LogToConsole(string log)
    {
        Console.WriteLine("=== Este é o Log para o Console ===");
        Console.WriteLine(log);
    }
    public void LogToFile(string log)
    {
        Console.WriteLine("+++ Este é o Log para o File +++");
        Console.WriteLine(log);
    }
    public void LogToDatabase(string log)
    {
        Console.WriteLine("___ Este é o Log para o Database ___");
        Console.WriteLine(log);
    }
}