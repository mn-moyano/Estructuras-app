public class Traductor
{
    public static void run()
    {
        Dictionary<string, string> palabras = new Dictionary<string, string>();
        palabras.Add("Time", "tiempo");
        palabras.Add("Year", "año");
        palabras.Add("Day", "día");
        palabras.Add("Life", "vida");
        palabras.Add("Man", "hombre");
        palabras.Add("Eye", "ojo");
        palabras.Add("Woman", "mujer");
        palabras.Add("Work", "trabajo");
        palabras.Add("Week", "semana");
        palabras.Add("Place", "lugar");

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
}