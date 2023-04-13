//criar os metodos para as demais operacoes matematicas (+ - * /)
static float Somar(float n1, float n2)
{
    return (n1 + n2);
}

static float Subtrair(float n1, float n2)
{
    return (n1 - n2);
}

static float Multiplicar(float n1, float n2)
{
    return (n1 * n2);
}

static float Dividir(float n1, float n2)
{
    return (n1 / n2);
}

Console.WriteLine(@$"
Informe a operacao desejada
+ para somar
- para subtrair
* para multiplicar
/ para dividir
");
string operacao = Console.ReadLine();

Console.WriteLine($"Informe o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe o segundo numero:");
float n2 = float.Parse(Console.ReadLine());


switch (operacao)
{
    case "+":
        Console.WriteLine($"O resultado da soma e {Somar(n1, n2)}");
        break;

    case "-":
        Console.WriteLine($"O resultado da subtracao e {Subtrair(n1, n2)}");
        break;

    case "*":
        Console.WriteLine($"O resultado da multiplicacao e {Multiplicar(n1, n2)}");
        break;

    case "/":
        Console.WriteLine($"O resultado da divisao e {Dividir(n1, n2)}");
        break;

    default:
        Console.WriteLine($"Operacao errada! Reinicie a operacao");
        break;
}
