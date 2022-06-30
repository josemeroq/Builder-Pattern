   class AutoBuilder : VehiculoBuilder  //clase hija constructora "ConcreteBuilder"
    {
        public AutoBuilder()
        {
            vehiculo = new Vehiculo("Auto");
        }
        public override void ConstruirChasis()
        {
            vehiculo["Chasis"] = "Car Frame";
        }
        public override void ConstruirMotor()
        {
            vehiculo["Motor"] = "2500 cc";
        }
        public override void ConstruirRuedas()
        {
            vehiculo["Ruedas"] = "4";
        }
        public override void ConstruirPuertas()
        {
            vehiculo["Puertas"] = "4";
        }
    }
