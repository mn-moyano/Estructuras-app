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

        int opcion = -1; //Controla el ciclo del menú
        while (opcion != 0) //Cerrar el bucle al salir
        {
            System.Console.WriteLine("=======Menú====="); //Crear el menú interactivo
            System.Console.WriteLine("1. Buscar libro por autor(id)");
            System.Console.WriteLine("2. Agregar libro");
            System.Console.WriteLine("3. Mostrar libros");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine()); //Leer la opción desde la consola
            

            if (opcion == 1) //Busca el ID del libro si está en la biblioteca
            {
                System.Console.WriteLine("Ingrese el ID del libro a buscar: ");
                int id = int.Parse(Console.ReadLine());

                if (libros.ContainsKey(id))
                {
                    System.Console.WriteLine($"El libro con ID {id} es: {libros[id]}");
                }
                else
                {
                    System.Console.WriteLine("No se encontró libro con ese ID."); //Si no está, aparecerá este mensaje
                }
            }
            else if (opcion == 2) //Agregar un libro con su clave y valor
            {
                System.Console.WriteLine("Ingrese ID del libro: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese título del libro: ");
                string titulo = Console.ReadLine();

                System.Console.WriteLine("Ingrese autor del libro: ");
                string autor = Console.ReadLine();

                if (titulos.Contains(titulo))
                {
                    System.Console.WriteLine($"El libro '{titulo}' ya está registrado.");
                }
                else
                {
                    titulos.Add(titulo); //Agrega al conjunto para evitar repetición
                    libros[id] = $"{autor} - {titulo}"; //Se agrega al diccionario
                    System.Console.WriteLine("Libro agregado correctamente.");
                }
            }
            else if (opcion == 3)
            {
                System.Console.WriteLine("Listado de libros registrados:"); //Mostramos los libros registrados
                foreach (var item in libros)
                {
                    System.Console.WriteLine($"ID: {item.Key}, {item.Value}");
                }
            }
            else if (opcion == 0) //Salimos del programa y fianliza el bucle
            {
                System.Console.WriteLine("Saliendo...");
            }
            else
            {
                System.Console.WriteLine("Error, opción inválida."); //En caso de error
            }
        }
    }
}