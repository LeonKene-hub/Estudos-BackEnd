//entrada, criar os numeros
int[] numeros = new int[5];

//processamento
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero:");
    numeros[i] = int.Parse(Console.ReadLine());
}

//saida
foreach (var item in numeros)
{
    Console.WriteLine($"O dobro e: {item * 2}");
}