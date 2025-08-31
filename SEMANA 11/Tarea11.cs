public class Traductor //Crear la clase Traductor
{
    public static void run() //Crear método
    {
        Dictionary<string, string> palabras = new Dictionary<string, string>(); //Crear diccionario con 10 palabras 
        palabras.Add("tiempo", "time");
        palabras.Add("año", "year");
        palabras.Add("dia", "day");
        palabras.Add("vida", "life");
        palabras.Add("hombre", "man");
        palabras.Add("ojo", "eye");
        palabras.Add("mujer", "woman");
        palabras.Add("trabajo", "work");
        palabras.Add("semana", "week");
        palabras.Add("lugar", "place");

        int opcion = -1; //Controla el ciclo del menú
        while (opcion != 0) //Bucle principal que se ejecuta hasta salir
        {
            System.Console.WriteLine("==============Menú================"); //Crear el menú de opciones
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); //Leemos la opción que ingresa el usuario

            if (opcion == 1) //Realiza la traducción de la frase ingresada
            {
                System.Console.WriteLine("Ingrese frase en español: ");
                string frase = Console.ReadLine();
                string[] partes = frase.Split(' '); //Nos ayuda a dividir la frase en palabras 

                System.Console.WriteLine("Traducción: ");
                foreach (var palabraEspanol in partes)
                {
                    if (palabras.ContainsKey(palabraEspanol)) //Si la palabra existe en el diccionario muestra la traducción
                        System.Console.Write(palabras[palabraEspanol] + " ");
                    else
                        System.Console.Write(palabraEspanol + " "); //Si no existe, se muestra la palabra original
                }
                System.Console.WriteLine();
            }
            else if (opcion == 2) //Permite agregar una nueva palabra al diccionario
            {
                System.Console.WriteLine("Ingrese palabra en español: ");
                string palabraEspanol = Console.ReadLine();

                System.Console.WriteLine("Ingrese palabra en inglés: ");
                string palabraIngles = Console.ReadLine();

                
                if (palabras.ContainsKey(palabraEspanol)) //Se verifica si la palabra ingresada ya existe
                {
                    System.Console.WriteLine("Palabra ya existe");
                }
                else
                {
                    palabras.Add(palabraEspanol, palabraIngles); //Si no existe, se agrega correctamente al diccionario
                    System.Console.WriteLine("Palabra agregada correctamente.");
                }
            }
            else if (opcion == 0) //Salimos del programa
            {
                System.Console.WriteLine("Saliendo...");
            }
            else
            {
                System.Console.WriteLine("Opción inválida."); //Si se ingresa un dato inválido aparece este mensaje
            }
        } 
    }
}