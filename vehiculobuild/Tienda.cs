class Tienda  //clase "Director" 
    {
        // El patron builder utiliza una serie complea de pasos
        public void Construir(VehiculoBuilder vehiculoConstruir)
        {
            vehiculoConstruir.ConstruirChasis();
            vehiculoConstruir.ConstruirMotor();
            vehiculoConstruir.ConstruirRuedas();
            vehiculoConstruir.ConstruirPuertas();
        }
    }
