Console.WriteLine("Digite um número");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite um número");
float n2 = float.Parse(Console.ReadLine());

float soma = n1 + n2;
float sub = n1 - n2;
float mult = n1 * n2;
float div = n2 / n2;

Console.WriteLine("A soma é igual a " + soma + "\nA subtração é igual a " + sub + "\nA divisão é igual a " + div + "\nA multiplicação é igual a " + mult);
Console.ReadLine();