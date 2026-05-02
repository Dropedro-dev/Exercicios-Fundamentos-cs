namespace Ex3;

class Program
{
    static void Main()
    {
        bool escolherNumero = true;
        bool escolherOperacao = true;

        string tipoOperacao;

        double a;
        double b;

        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        void EscolherSecao()
        {
            
            string secao;
            Console.WriteLine("Escolha a seção desejada:");
            Console.WriteLine("1 - Escolher números");
            Console.WriteLine("2 - Escolher operação");
            Console.WriteLine("3 - Sair");
            secao = Console.ReadLine();

            if (secao == "1")
            {
                escolherOperacao = false;
                Console.Clear();
            }
            else if (secao == "2")
            {
                Console.Clear();
                return;
            }
            else if (secao == "3")
            {
                escolherNumero = false;
                escolherOperacao = false;
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                EscolherSecao();
            }
        }

        do
        {
            Console.WriteLine("Digite o primeiro número:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            b = Convert.ToDouble(Console.ReadLine());
            
            escolherOperacao = true;

            while (escolherOperacao)
            {
                Console.WriteLine("Escolha a operação desejada:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Mudar números");
                Console.WriteLine("6 - Sair");
                tipoOperacao = Console.ReadLine();

                switch (tipoOperacao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Resultado: {operacoes.Somar(a, b)}");
                        EscolherSecao();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Resultado: {operacoes.Subtrair(a, b)}");
                        EscolherSecao();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Resultado: {operacoes.Multiplicar(a, b)}");
                        EscolherSecao();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"Resultado: {operacoes.Dividir(a, b)}");
                        EscolherSecao();
                        break;
                    case "5":
                        Console.Clear();
                        escolherOperacao = false;
                        break;
                    case "6":
                        escolherNumero = false;
                        escolherOperacao = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        continue;

                }

            }
        } while (escolherNumero);
    }
}