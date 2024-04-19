float n1=0, n2=0, n3=0, n4=0, resultado;
int operacao;

Console.WriteLine("Digite o primeiro número");
n1 = float.Parse(Console.ReadLine());

while (n2 == 0)
{
    Console.WriteLine("Digite o segundo número");
    n2 = float.Parse(Console.ReadLine());
}

do
{
    Console.WriteLine("Digite o terceiro número");
    n3 = float.Parse(Console.ReadLine());
} while (n3 == 0);

for (n4 = 0; n4 == 0;)
{
    Console.WriteLine("Digite o quarto número");
    n4 = float.Parse(Console.ReadLine());
}

Console.WriteLine("Escolha a operação desejada: \n1-Soma\n2-Subtracao\n3-Multiplicacao\n4-Divisao");
operacao = int.Parse(Console.ReadLine());

if (operacao == 1)
{
    resultado = n1 + n2 + n3 + n4;
    Console.WriteLine("A soma é igual a " + resultado);
}
else if (operacao == 2)
{ 
    resultado = n1 - n2 - n3 - n4;
    Console.WriteLine("A subtracao é igual a " + resultado);
}
else if (operacao == 3)
{
    resultado = n1 * n2 * n3 * n4;
    Console.WriteLine("A multiplicacao é igual a " + resultado);
}
else 
{
    resultado = n1 / n2 / n3 / n4;
    Console.WriteLine("A divisao é igual a " + resultado);
}

Console.ReadLine();