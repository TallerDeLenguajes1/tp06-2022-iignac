using Ejercicio2;

Empleado empleado1 = new Empleado("Gustavo", "Cerati", new DateTime(1980,5,27), 'C', 'H', new DateTime(2007,5,26), 65000, Cargos.Ingeniero);
Empleado empleado2 = new Empleado("Bruce", "Wayne", new DateTime(1970,1,26), 'S', 'H', new DateTime(2015,9,12), 75000, Cargos.Investigador);
Empleado empleado3 = new Empleado("Megan", "Fox", new DateTime(1990,12,16), 'D', 'M', new DateTime(1990,5,3), 50000, Cargos.Administrativo);

Console.WriteLine("\n===> Monto total de los salarios: $" + TotalSalarios());

Console.WriteLine("\n----------------------------");

Console.WriteLine("\n===> Empleado próximo a jubilarse:\n");
ProximoAjubilarse().MostrarEmpleado();


// métodos
double TotalSalarios()
{
    return empleado1.Salario() + empleado2.Salario() + empleado3.Salario();
}

Empleado ProximoAjubilarse()
{
    if ( (empleado1.Jubilacion() <= empleado2.Jubilacion()) && (empleado1.Jubilacion() <= empleado3.Jubilacion()) )
    {
        return empleado1;
    }
    else
    {
        if ( (empleado2.Jubilacion() <= empleado1.Jubilacion()) && (empleado2.Jubilacion() <= empleado3.Jubilacion()) )
        {
            return empleado2;
        }
        else
        {
            return empleado3;
        }
    }
}