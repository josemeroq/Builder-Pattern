    class MotocicletaBuilder : VehiculoBuilder  //clase hija constructora "ConcreteBuilder"
    {
        public MotocicletaBuilder()
        {
            vehiculo = new Vehiculo("Motocicleta");
        }
        public override void ConstruirChasis()
        {
            vehiculo["Chasis"] = "MotorCycle Frame";
        }
        public override void ConstruirMotor()
        {
            vehiculo["Motor"] = "500 cc";
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
 