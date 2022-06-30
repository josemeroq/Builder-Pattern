   class Vehiculo   //clase "Product"
    {
        private string _tipoVehi;

        //Creamos un diccionario el cual nos permite almacenar datos a traves de un indexer
        private Dictionary<string, string> _partes =
          new Dictionary<string, string>();
        // Constructor
        public Vehiculo(string tipoVehi)
        {
            this._tipoVehi = tipoVehi;
        }
        // Indexer del diccionario mediante una key
        public string this[string key]
        {
            get { return _partes[key]; }
            set { _partes[key] = value; }
        }
        //Metodo que muestra los datos
        public void Mostrar()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo Vehiculo: {0}", _tipoVehi);
            Console.WriteLine(" Chasis : {0}", _partes["Chasis"]);
            Console.WriteLine(" Motor : {0}", _partes["Motor"]);
            Console.WriteLine(" N° Ruedas: {0}", _partes["Ruedas"]);
            Console.WriteLine(" N° Puertas : {0}", _partes["Puertas"]);
        }
 }
