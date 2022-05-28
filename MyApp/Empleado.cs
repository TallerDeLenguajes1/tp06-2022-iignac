namespace Ejercicio2
{
    public enum Cargos{Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}

    public class Empleado
    {
        // campos
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil; // S: soltero, C: casado, D: divorciado, V: viudo
        private char genero; // H: hombre, M: mujer
        private DateTime fechaDeIngreso;
        private double sueldoBasico;
        private Cargos cargo;
        ////////
     
        // constructor
        public Empleado(string nombreEmpleado, string apellidoEmpleado, DateTime fechaDeNacimientoEmpleado, char estadoCivilEmpleado, char generoEmpleado, DateTime fechaDeIngresoEmpleado, double sueldoBasicoEmpleado, Cargos cargoEmpleado)
        {
            nombre = nombreEmpleado;
            apellido = apellidoEmpleado;
            fechaDeNacimiento = fechaDeNacimientoEmpleado;
            estadoCivil = estadoCivilEmpleado;
            genero = generoEmpleado;
            fechaDeIngreso = fechaDeIngresoEmpleado;
            sueldoBasico = sueldoBasicoEmpleado;
            cargo = cargoEmpleado;
        }
        ///////

        // propiedades (no las uso en este ejercicio)
        // public string Nombre { get => nombre; set => nombre = value; }
        // public string Apellido { get => apellido; set => apellido = value; }
        // public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        // public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        // public char Genero { get => genero; set => genero = value; }
        // public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
        // public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        // public Cargos Cargo { get => cargo; set => cargo = value; }

        // métodos
        public int Antiguedad()
        {
            int antiguedadAnios = DateTime.Now.Year - fechaDeIngreso.Year;

            if (DateTime.Now.Month <= fechaDeIngreso.Month && DateTime.Now.Day <= fechaDeIngreso.Day)
            {
                antiguedadAnios--;
            }
            return antiguedadAnios;            
        }

        public int Edad()
        {
            int edad = DateTime.Now.Year - fechaDeNacimiento.Year;

            if (DateTime.Now.Month <= fechaDeNacimiento.Month && DateTime.Now.Day <= fechaDeNacimiento.Day)
            {
                edad--;
            }
            return edad;
        }

        public int Jubilacion()
        {
            int aniosParaJubilarse;
            if (genero == 'H')
            {
                aniosParaJubilarse = 65 - Edad();
            }
            else
            {
                aniosParaJubilarse = 60 - Edad(); 
            }

            if (aniosParaJubilarse < 0) // si aniosParaJubilarse es < 0 entonces alcanzó (supera) la edad para poder jubilarse
            {
                return 0;
            }
            else
            {
                return aniosParaJubilarse;
            }
        }

        public double Salario()
        {
            double adicional = 0;

            if (Antiguedad() <= 20)
            {
                adicional = sueldoBasico * 0.01 * Antiguedad();
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional += adicional * 0.5; // adicional = adicional * 1.5
            }

            if (estadoCivil == 'C')
            {
                adicional += 15000; 
            }

            return sueldoBasico + adicional;;
        }

        public void MostrarEmpleado()
        {   
            Console.WriteLine("== DATOS PERSONALES ==");
            MostrarDatosPersonales();
            Console.WriteLine("\n");
            Console.WriteLine("== DATOS LABORALES ==");
            MostrarDatosLaborales();
        }

        public void MostrarDatosPersonales()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Fecha de nacimiento: " + fechaDeNacimiento.ToShortDateString());
            Console.WriteLine("Edad: " + Edad());
            
            switch (estadoCivil)
            {
                case 'S':
                    Console.WriteLine("Estado civil: Soltero/a");
                    break;
                case 'C':
                    Console.WriteLine("Estado civil: Casado/a");
                    break;
                case 'D':
                    Console.WriteLine("Estado civil: Divorciado/a");
                    break;
                case 'V':
                    Console.WriteLine("Estado civil: Viudo/a");
                    break;
            }

            switch (genero)
            {
                case 'H':
                    Console.WriteLine("Genero: Hombre");
                    break;
                case 'M':
                    Console.WriteLine("Genero: Mujer");
                    break;
            }
        }

        public void MostrarDatosLaborales()
        {
            Console.WriteLine("Fecha de ingreso a la empresa: " + fechaDeIngreso.ToShortDateString());
            Console.WriteLine("Antiguedad: " + Antiguedad() + " años");
            Console.WriteLine("Años faltantes para jubilarse: " + Jubilacion());
            Console.WriteLine("Cargo: " + cargo.ToString()); // Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Sueldo básico: $" + sueldoBasico);
            Console.WriteLine("Salario: $" + Salario());
        }
    }
}