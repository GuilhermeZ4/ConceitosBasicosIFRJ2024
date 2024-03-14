using System.Net.NetworkInformation;
int opcao = 0;

do
{
    Console.WriteLine("Informe oq deseja fazer:");
    Console.WriteLine("(1) calcular IMC");
    Console.WriteLine("(2) Jogo de adivinhação");
    Console.WriteLine("(0) Encerrar");
    opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 1)
        CalcularIMC();
} 

while (opcao != 0);
Console.WriteLine("Obrigado pela sua participação!");
Console.WriteLine("Programa Finalizado");

static void CalcularIMC()
{
    Console.WriteLine("Informe seu peso:");
    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe sua altura:");
    float altura = float.Parse(Console.ReadLine());

    float imc = peso / (altura * altura);

    Console.WriteLine($"Para o peso {peso} e a altura {altura} o imc calculado foi {imc: f1} \n\n");

    string status = string.Empty;

    if (imc < 18.5)
        status = "Magreza:";

    else if (imc <= 24.9)
        status = "Normal:";

    else if (imc <= 29.9)
        status = "Sobrepeso:";

    else if (imc <= 39.9)
        status = "Obesidade:";

    else
        status = "Obesidade grave:";
    Console.WriteLine($"o {imc} indica a classificação:\n\n {status}");
}









