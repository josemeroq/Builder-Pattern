    abstract class VehiculoBuilder     //clase abstracta constructora "Builder"
    {
        //modificador protected para acceder desde los metodos de la clase que
        //pertenecen al mismo paquete
        protected Vehiculo vehiculo; 
        // Obtiene la instancia del vehículo
        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
        }
        // Metodos de construcción abstractos
        public abstract void ConstruirChasis();
        public abstract void ConstruirMotor();
        public abstract void ConstruirRuedas();
        public abstract void ConstruirPuertas();
    }
    