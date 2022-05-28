int repetir;
Console.WriteLine("Ingrese el número que desea operar:");
double numero = Convert.ToDouble(Console.ReadLine());
Calculadora calc = new Calculadora(numero);

do{
    Console.WriteLine("Ingrese la operación que desea realizar:");
    Console.WriteLine("[1] sumar, [2] restar, [3] multiplicar, [4] dividir, [5] Limpiar");
    double operacion = Convert.ToDouble(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            calc.Sumar(numero);
            break;
        case 2:
            calc.Restar(numero);
            break;
        case 3:
            calc.Multiplicar(numero);
            break;
        case 4:
            calc.Dividir(numero);
            break;
        case 5:
            calc.Limpiar();
            break;
    }
    
    Console.WriteLine("El resultado es: " + calc.resultado);
    Console.WriteLine("Desea realizar otro cálculo? (1: Si, 0: No)");
    repetir = Convert.ToInt32(Console.ReadLine());
} while (repetir==1);