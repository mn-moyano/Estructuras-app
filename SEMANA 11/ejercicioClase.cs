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
    }
}