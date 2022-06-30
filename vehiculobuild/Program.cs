    public class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            VehiculoBuilder construir;
            //crea la tienda con constructores de Vehiculo
            Tienda tienda = new Tienda();
            //Construye los objetos(Vehiculos) y los muestra
            construir = new ScooterBuilder();
            tienda.Construir(construir);
            construir.Vehiculo.Mostrar();
            construir = new AutoBuilder();
            tienda.Construir(construir);
            construir.Vehiculo.Mostrar();
            construir = new MotocicletaBuilder();
            tienda.Construir(construir);
            construir.Vehiculo.Mostrar();
            //
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite cualquier tecla para salir.");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Director' class
    /// </summary>



