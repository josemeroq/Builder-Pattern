    class ScooterBuilder : VehiculoBuilder  //clase hija constructora "ConcreteBuilder"
    {
        public ScooterBuilder()
        {
            vehiculo = new Vehiculo("Scooter");
        }
        public override void ConstruirChasis()
        {
            vehiculo["Chasis"] = "Scooter Chasis";
        }
        public override void ConstruirMotor()
        {
            vehiculo["Motor"] = "50 cc";
        }
        public override void ConstruirRuedas()
        {
            vehiculo["Ruedas"] = "2";
        }
        public override void ConstruirPuertas()
        {
            vehiculo["Puertas"] = "0";
        }
    }