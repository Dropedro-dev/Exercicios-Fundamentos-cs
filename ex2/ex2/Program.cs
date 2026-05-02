namespace Ex2;

class Program
{
    static void Main()
    {
        string firstName;
        string lastName;

        Console.WriteLine("Digite seu primeiro nome:");
        firstName = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        lastName = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é: {firstName} {lastName}");
    }
}