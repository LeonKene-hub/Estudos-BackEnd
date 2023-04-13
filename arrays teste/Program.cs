string[] carros = new string[3];

Console.WriteLine($"Digite e cadastre 3 carros diferentes:");

for (int i = 0; i < carros.Length; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine($"Cadastre o primeiro carro:");
            carros[i] = Console.ReadLine();
            break;

        case 1:
            Console.WriteLine($"Cadastre o segundo carro:");
            carros[i] = Console.ReadLine();
            break;

        case 2:
            Console.WriteLine($"Cadastre o terceiro carro:");
            carros[i] = Console.ReadLine();
            break;

        default:
            Console.WriteLine($"erro");
            break;
    }
}

Console.WriteLine(@$"
/----------------------------\
| Os carros registrados sao: |
\----------------------------/
");

for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine(carros[i]);
}