namespace actividad3 { 
class Program { 
    public static void Main(string[] args) {

            string strCapacidad, strPorcentajeCombustible, strConsumo;
            double distanciaRequerida = 200;

            //Ingreso en String
            Console.WriteLine("Ingrese la capacidad del tanque en Litros");
            strCapacidad = Console.ReadLine();
            Console.WriteLine("Ingrese el porcentaje de combustible disponible");
            strPorcentajeCombustible = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de kilometros x litro que consume");
            strConsumo = Console.ReadLine();

            //Conversion de String a Double 
            double capacidad = double.Parse(strCapacidad);
            double porcentajeCombustible = double.Parse(strPorcentajeCombustible);
            double consumo = double.Parse(strConsumo);

            //Calculos 
            double combustible = capacidad * porcentajeCombustible / 100;
            double distanciaPosible = combustible * consumo;

            //Condicional y Respuesta 
            if(distanciaPosible <  distanciaRequerida) {
                Console.WriteLine("Necesita Combustible");
            }
            else {
                Console.WriteLine("Combustible Suficiente");
            }

       
        }  
    }
}
