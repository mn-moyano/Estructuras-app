public class ClaveValor
{
    public static void run()
    {
        //Definición de un diccionario
        Dictionary<int, string> estudiantes = new Dictionary<int, string>();
        estudiantes.Add(1, "Juan");
        estudiantes.Add(2, "Pedro");
        estudiantes.Add(3, "Maria");
        estudiantes.Add(4, "Anabel");

        //Definición e inicialización de un diccionario
        Dictionary<int, string> docentes = new()
        {
            {1, "Anita"}
        };

        System.Console.WriteLine("--Lista de estudiantes--");
        System.Console.WriteLine("Ingrese un código: ");
        int codigo = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el nombre: ");
        string nombre = Console.ReadLine();

        if (estudiantes.ContainsKey(codigo))
        {
            System.Console.WriteLine("El código ya existe");
        }
        else
        {
            estudiantes.Add(codigo, nombre);
        }
        System.Console.WriteLine(estudiantes[4]);
    }
}