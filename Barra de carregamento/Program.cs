static void BarraCarremento(string texto, int quantidadePontinhos, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write(texto);
    
    for (int i = 0; i <= quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

BarraCarremento("Carregando", 8, 1000);