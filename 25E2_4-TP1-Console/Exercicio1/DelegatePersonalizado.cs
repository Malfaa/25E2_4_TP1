namespace _25E2_4_TP1_Console.Exercicio1;

public class DelegatePersonalizado
{
    public delegate double CalculateDiscount(double preco);
    
    public static double Desconto(double valor)
    {
        return valor * 0.90		;
    }
}