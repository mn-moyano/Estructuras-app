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

        int opcion = -1;
        while (opcion != 0)
        {
            System.Console.WriteLine("==============Menú================");
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                System.Console.WriteLine("Ingrese frase en español: ");
                string frase = Console.ReadLine();
                string[] partes = frase.Split(' ');

                System.Console.WriteLine("Traducción: ");
                foreach (var palabraEspanol in partes)
                {
                    if (palabras.ContainsKey(palabraEspanol))
                        System.Console.Write(palabras[palabraEspanol] + " ");
                    else
                        System.Console.Write(palabraEspanol + " ");
                }
                System.Console.WriteLine();
            }
            else if (opcion == 2)
            {
                System.Console.WriteLine("Ingrese palabra en inglés: ");
                string palabraIngles = Console.ReadLine();
                System.Console.WriteLine("Ingrese palabra en español: ");
                string palabraEspanol = Console.ReadLine();
                if (palabras.ContainsKey(palabraIngles))
                {
                    System.Console.WriteLine("Palabra ya existe");
                }
                else
                {
                    palabras.Add(palabraIngles, palabraEspanol);
                    System.Console.WriteLine("Palabra agregada correctamente.");
                }
            }
            else if (opcion == 0)
            {
                System.Console.WriteLine("Saliendo...");
            }
            else
            {
                System.Console.WriteLine("Opción inválida.");
            }
        } 
    }
}