namespace Ex4;

class Program
{
    static void Main()
    {
        string texto;
        int numpalavras;
        int numCharacteres;
        
        Console.WriteLine("Digite uma palavra ou frase:");
        texto = Console.ReadLine() ?? string.Empty;

        numpalavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        numCharacteres = texto.Replace(" ", "").Length;

        Console.WriteLine($"Número de palavras: {numpalavras}");
        Console.WriteLine($"Número de caracteres (sem espaços): {numCharacteres}");

        Console.WriteLine($"");
    }
}