public class Catalogo //Creamos la clase catálogo
{
    public static void run()//Creamos el método que ejecuta el programa
    {
        List<string> revistas = new List<string> { "Forbes", "People", "Time", "Caras", "Vistazo",
            "Nature", "The Economist", "National Geographic", "Chic", "Glow" };//Creamos una lista de revistas

        int opcion = -1; //Controla el ciclo del menú
        while (opcion != 0) //Bucle que se ejecuta hasta salir
        {
            System.Console.WriteLine("=====Catálogo de Revistas====="); //Menú interactivo
            System.Console.WriteLine("**************Menú************");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); //Opcion para leer desde la consola

            if (opcion == 1)//Realiza la búsqueda de la revista
            {
                System.Console.WriteLine("Ingrese el título de la revista a buscar: ");
                string titulo = Console.ReadLine();

                bool encontrado = buscarIterativo(revistas, titulo);//Llamamos a la función de búsqueda iterativa

                if (encontrado)
                    System.Console.WriteLine("Encontrado");
                else
                    System.Console.WriteLine("No encontrado");
            }
            else if (opcion == 0) //Salimos del programa
            {
                System.Console.WriteLine("Saliendo...");
            }
            else
            {
                System.Console.WriteLine("Opción inválida.");
            }
        }
        bool buscarIterativo(List<string> lista, string titulo) //Función local de búsqueda iterativa
        {
            foreach (var item in lista)
            {
                if (item.Equals(titulo, StringComparison.OrdinalIgnoreCase)) //Comparación ignorando mayúsculas y minúsculas
                    return true; //Si encontramos nos dará el mensaje de encontrado
            }
            return false; //Si no encontramos nos dará el mensaje de no encontrado
        }
    }
}