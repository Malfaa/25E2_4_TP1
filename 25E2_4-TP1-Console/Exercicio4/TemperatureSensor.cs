namespace _25E2_4_TP1_Console.Exercicio4;

public class TemperatureSensor
{	
    public event EventHandler<double>? TemperaturaExceeded;
	
    public void TempReader(double temperatura)
    {
        if(temperatura > 100)
        {
            TemperaturaExceeded?.Invoke(this, temperatura);
        }
    }
}