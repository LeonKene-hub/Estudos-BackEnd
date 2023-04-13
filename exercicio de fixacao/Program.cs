//exercicio de fixacao
//escreva um programa que receba e imprima o nome e idade de 5 pessoas

string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{i + 1}º Escreva o seu nome:");
    nomes[i] = Console.ReadLine();
    Console.WriteLine($"{i + 1}º Digite sua idade:");
    idades[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < idades.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i + 1}) nome: {nomes[i]}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"   idade: {idades[i]} anos");
    Console.ResetColor();
}