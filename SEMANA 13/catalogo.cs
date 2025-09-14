public class Catalogo
{
    public static void run()
    {
        List<string> revistas = new List<string> { "Forbes", "People", "Time", "Caras", "Vistazo", "Nature", "The Economist", "National Geographic", "Chic", "Glow" };

        int opcion = -1;
        while (opcion != 0)
        {
            System.Console.WriteLine("=====Catálogo de Revistas=====");
            System.Console.WriteLine("**************Menú************");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                System.Console.WriteLine("Ingrese el título de la revista a buscar: ");
                string titulo = Console.ReadLine();

                bool encontrado = buscarIterativo(revistas, titulo);

                if (encontrado)
                    System.Console.WriteLine("Encontrado");
                else
                    System.Console.WriteLine("No encontrado");
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
        bool buscarIterativo(List<string> lista, string titulo)
        {
            foreach (var item in lista)
            {
                if (item.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}