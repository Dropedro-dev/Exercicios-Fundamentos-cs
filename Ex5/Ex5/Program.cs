namespace Ex5;

class Program
{
    static void Main()
    {
        string placa;

        bool IsPlacaValida(string placa)
        {
            if (placa.Length != 8)
                return false;
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                    return false;
            }
            if (placa[3] != '-')
                return false;
            for (int i = 4; i < 8; i++)
            {
                if (!char.IsDigit(placa[i]))
                    return false;
            }
            return true;
        }

        Console.WriteLine("Digite a placa do veículo (formato: ABC-1234):");
        placa = Console.ReadLine();

        if (IsPlacaValida(placa))
        {
            Console.WriteLine("Placa válida.");
        }
        else
        {
            Console.WriteLine("Placa inválida. O formato deve ser ABC-1234.");
        }
    }
}