
Console.WriteLine("Informe seu peso:");
int p = int.Parse (Console.ReadLine());

Console.WriteLine("Informe sua altura:");
float a = float.Parse (Console.ReadLine());

float imc = p / (a*a);

Console.WriteLine($"Para o peso {p} e a altura {a} o imc calculado foi {imc : f1} ");


if (imc <= 16.9)
    Console.WriteLine("Muito abaixo do peso:");

else if (imc <= 18.4)
    Console.WriteLine("Abaixo do peso");







