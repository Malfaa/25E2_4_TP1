﻿using _25E2_4_TP1_Console.Exercicio1;
using _25E2_4_TP1_Console.Exercicio2;
using _25E2_4_TP1_Console.Exercicio4;
using _25E2_4_TP1_Console.Exercicio5;
using _25E2_4_TP1_Console.Exercicio6;
using _25E2_4_TP1_Console.Exercicio7;
using _25E2_4_TP1_Console.Exercicio11;

namespace _25E2_4_TP1_Console;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\n=== Escolha um exercício para executar ===");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("7 - Exercício 7");
            Console.WriteLine("11 - Exercício 11");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha um exercício: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    DelegatePersonalizado.CalculateDiscount calculo = DelegatePersonalizado.Desconto;
                    Console.WriteLine("Digite o valor do produto original: ");
                    double valor = 0;
                    bool fecharCorrecao = false;
                    while (fecharCorrecao == false)
                    {
                        valor = Convert.ToDouble(Console.ReadLine());
                        if (valor > 0)
                        {
                            fecharCorrecao = true;
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido, tente novamente.");
                        }
                    }

                    double descValor = calculo(valor);
		
                    Console.WriteLine($"O valor com desconto é de: R${descValor:F2}");
                    break;
                
                case 2:
                    Console.WriteLine("\nEscolha seu idioma digitando seu número:");
                    Console.WriteLine("1- Português");
                    Console.WriteLine("2- Inglês");
                    Console.WriteLine("3- Espanhol");
                    Console.WriteLine("Digite a opção: ");
                    int idioma = Convert.ToInt32(Console.ReadLine());
	
                    Action<string>? mensagem = null;
                    bool exit = false;
                    while (exit == false)
                    {
                        switch(idioma) //atribuindo o método ao delegate
                        {
                            case 1: 
                                mensagem = MultiAction.MensagemPort;
                                exit = true;
                                break;
                            case 2:
                                mensagem = MultiAction.MensagemIng;
                                exit = true;
                                break;
                            case 3:
                                mensagem = MultiAction.MensagemEsp;
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                    Console.Write("Digite seu nome: ");
                    string nome = Console.ReadLine()!;
                    mensagem!(nome);	
                    break;
                case 3:
                    Console.WriteLine("Informe o comprimento do retângulo: ");
                    double comp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a altura do retângulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Func<double, double, double> calcularArea = (b, h) => b*h;
                    double area = calcularArea(comp, altura);
                    Console.WriteLine($"Área do retângulo é de: {area:F2} m².");
                    break;
                case 4:
                    var sensor = new TemperatureSensor();
                    Console.WriteLine("Insira valores da temperatura: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    sensor.TemperaturaExceeded += Alerta;
                    sensor.TempReader(temp);
                    break;
                case 5:
                    var down = new DownloadManager();
                    Console.WriteLine("Iniciando Download...");
                    Thread.Sleep(3000);
                    down.Download += Mensagem;
                    down.VerificaDownload(true);
                    break;
                case 6:
                    Logger logger = new Logger();
                    Action<string> log = logger.LogToConsole;
                    log += logger.LogToFile;
                    log += logger.LogToDatabase;
                    log("Devidos logs aparecendo!");
                    break;
                case 7:
                    InvocacaoDelegates invoDel = new InvocacaoDelegates();
                    Action<string> logs = invoDel.LogToConsole;
                    logs += invoDel.LogToFile;
                    logs += invoDel.LogToDatabase;
        
                    logs?.Invoke("Mensagem de teste com os métodos");
        
                    logs -= invoDel.LogToFile;
                    logs -= invoDel.LogToDatabase;
                    logs -= invoDel.LogToConsole;

                    logs?.Invoke("Mensagem testando método removidos");
                    
                    Console.WriteLine("\nLogs não causaram exception");
                    break;
                case 8:
                    Console.WriteLine("Exercício em outro projeto!");
                    break;
                case 9:
                    Console.WriteLine("Exercício em outro projeto!");
                    break;
                case 10:
                    Console.WriteLine("Exercício em outro projeto!");
                    break;
                case 11:
                    DelEnc conc = new DelEnc();
                    string nomeSobr = conc.ConcatenacaoNome("Gustavo","Malfa");
                    Console.WriteLine(nomeSobr);
                    break;
                case 12:
                    Console.WriteLine("Exercício em outro projeto!");
                    break;
                case 0 :
                    return;
            }
        }
    }

    private static void Alerta(object? sender, double temp) {
        Console.WriteLine($"CUIDADO! Temperatura acima de 100°C: {temp}°C");
    }
    private static void Mensagem(object? sender, bool b)
    {
        Console.WriteLine("Download concluído!");
    }
}