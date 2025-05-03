using System.Diagnostics.Tracing;

namespace _25E2_4_TP1_Console.Exercicio7;

public class InvocacaoDelegates
{
    
    public event EventHandler<string>? Evento;

    public void LogToConsole(string log)
    {
        
        Console.WriteLine("=== Este é o Log para o Console ===");
        Console.WriteLine(log);
        Evento?.Invoke(this, log);
    }
    public void LogToFile(string log)
    {
        Console.WriteLine("+++ Este é o Log para o File +++");
        Console.WriteLine(log);
        Evento?.Invoke(this, log);

    }
    public void LogToDatabase(string log)
    {
        Console.WriteLine("___ Este é o Log para o Database ___");
        Console.WriteLine(log);
        Evento?.Invoke(this, log);

    }
}