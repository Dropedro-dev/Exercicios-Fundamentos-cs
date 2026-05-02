namespace Ex3;

public class OperacoesMatematicas
{
    public double Somar(double A,double B) => A + B;

    public double Subtrair(double A, double B) => A - B;

    public double Multiplicar(double A, double B) => A * B;

    public double Dividir(double A, double B)
    {
        if (B == 0)
            throw new DivideByZeroException("Não é possível dividir por zero.");
        return A / B;
    }
}
