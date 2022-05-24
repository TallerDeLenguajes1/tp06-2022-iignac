public class Calculadora
{
    public double Resultado;
    public Calculadora(double valorInicial)
    {
        Resultado = valorInicial;
    }

    public void Sumar(double valor)
    {
        Resultado+=valor;
    }

    public void Restar(double valor)
    {
        Resultado-=valor;
    }

    public void Multiplicar(double valor)
    {
        Resultado*=valor;
    }

    public void Dividir(double valor)
    {
        Resultado/=valor;
    }

    public void Limpiar()
    {
        Resultado=0;
    }
}