Console.WriteLine("Digite o primeiro número");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Escolha a operação desejada: \n1-Soma\n2-Subtracao\n3-Multiplicacao\n4-Divisao");
int operacao = int.Parse(Console.ReadLine());

if (operacao == 1)
{
    float soma = n1 + n2;
    Console.WriteLine("A soma é igual a " + soma);
}
else if (operacao == 2)
{ 
    float sub = n1 - n2;
    Console.WriteLine("A subtracao é igual a " + sub);
}
else if (operacao == 3)
{
    float mult = n1 * n2;
    Console.WriteLine("A multiplicacao é igual a " + mult);
}
else if (operacao == 4)
{
    if (n2 == 0)
    {
        Console.WriteLine("Não existe divisão por zero!");
    }
    else
    {
        float div = n1 / n2;
        Console.WriteLine("A divisao é igual a " + div);
    }
}

Console.ReadLine();