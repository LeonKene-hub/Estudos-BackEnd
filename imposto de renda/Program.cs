//metodo que calcule o imposto de renda

//ate 1500 - isento
//de 1501 ate 3500 - 20% de imposto
//de 3501 ate 6000 - 25% de imposto
//acima 6000 - 35% de imposto

Console.WriteLine($"Informe o seu salario:");
double salario = float.Parse(Console.ReadLine());

ImpostoDeRenda(salario);

static void ImpostoDeRenda(double n1)
{
    if (n1 <= 1500)
    {
        Console.WriteLine($"imposto isento");
    }
    else if (n1 > 1500 && n1 <= 3500)
    {
        Console.WriteLine($"Voce recebe {n1}, deve pagar {n1 * 0.2} de imposto de renda!");
    }
    else if (n1 > 3500 && n1 <= 6000)
    {
        Console.WriteLine($"Voce recebe {n1}, deve pagar {n1 * 0.25} de imposto de renda!");
    }
    else if (n1 > 6000)
    {
        Console.WriteLine($"Voce recebe {n1}, deve pagar {n1 * 0.35} de imposto de renda!");
    }
}
