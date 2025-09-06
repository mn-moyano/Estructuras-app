public class Biblioteca //Crear la clase biblioteca
{
    public static void run() //Crear el método de ejecución
    {
        HashSet<string> titulos = new HashSet<string>(); //Aplicar la estructura conjuntos para evitar repetición
        titulos.Add("Cien Años de Soledad");
        titulos.Add("Don Quijote de la Mancha");
        titulos.Add("Viaje al Centro de la Tierra");

        Dictionary<int, string> libros = new Dictionary<int, string>(); //Aplicar la estructura mapas para almacenar la información de los libros

        libros.Add(1, "Gabriel García Márquez - Cien Años de Soledad");
        libros.Add(2, "Miguel de Cervantes - Don Quijote de la Mancha");
        libros.Add(3, "Julio Verne - Viaje al Centro de la Tierra");


        while (true)
        {
            System.Console.WriteLine("=======Menú=====");
            System.Console.WriteLine("1. Buscar libro por autor(id)");
            System.Console.WriteLine("2. Agregar libro");
            System.Console.WriteLine("3. Mostrar libros");
            System.Console.WriteLine("4. Salir");
            System.Console.WriteLine("Elige una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                System.Console.WriteLine("Ingrese el ID del libro a buscar: ");
                int id = int.Parse(Console.ReadLine());

                if (libros.ContainsKey(id))
                {
                    System.Console.WriteLine($"El libro con ID {id} es: {libros[id]}");
                }
                else
                {
                    System.Console.WriteLine("No se encontró libro con ese ID.");
                }
            }
            else if (opcion == "2")
            {
                System.Console.WriteLine("Ingrese ID del libro: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese título del libro: ");
                string titulo = Console.ReadLine();
                
            }
        }
    }
}