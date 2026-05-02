namespace Ex6;

class Program
{
    static void Main()
    {
        DateTime hoje = DateTime.Now;

        Console.WriteLine($"Data completa: {hoje}");
        Console.WriteLine($"Data formato dd/mm/aaaa: {hoje:dd/MM/yyyy}");
        Console.WriteLine($"Data apenas hora com 24h: {hoje:HH:mm}");
        Console.WriteLine($"Data com mes por extenso: {hoje:dd 'de' MMMM 'de' yyyy}");
    }
}