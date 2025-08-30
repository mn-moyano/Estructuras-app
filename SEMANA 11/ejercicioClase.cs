using Microsoft.VisualBasic;

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

        estudiantes[1] = "Anita";
        System.Console.WriteLine(estudiantes[1]);

        if (estudiantes.ContainsKey(codigo))
        {
            System.Console.WriteLine("El código ya existe");
        }
        else
        {
            estudiantes.Add(codigo, nombre);
        }
        System.Console.WriteLine(estudiantes[4]);

        var claves = estudiantes.Keys;
        var valores = estudiantes.Values;

        foreach (var item in claves)
        {
            System.Console.WriteLine(item);
        }
        foreach (var item in valores)
        {
            System.Console.WriteLine(item);
        }
    }
}