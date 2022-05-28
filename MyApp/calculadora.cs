public class Calculadora
{
    // campo
    private double _resultado;

    // propiedad
    public double resultado { get => _resultado; } // no agrego 'set', entonces no permito que el usuario pueda setear el valor de _resultado

    // métodos
    public Calculadora(double valorInicial)
    {
        _resultado = valorInicial;
    }

    public void Sumar(double valor)
    {
        _resultado+=valor;
    }

    public void Restar(double valor)
    {
        _resultado-=valor;
    }

    public void Multiplicar(double valor)
    {
        _resultado*=valor;
    }

    public void Dividir(double valor)
    {
        _resultado/=valor;
    }

    public void Limpiar()
    {
        _resultado=0;
    }
}