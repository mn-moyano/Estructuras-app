//Asignar 30 asientos en una atracción
public class Colas
{
    public static void run()
    {
        Queue<string> personas = new Queue<string>();
        const int maxAsientos = 30;

        System.Console.WriteLine("Simulación: Asigación de 30 asientos en orden de llegada.");
        System.Console.WriteLine("Ingrese los nombres de los visitantes en orden de llegada (escriba 'fin' para terminar antes de los 30):");

        int contador = 0;
        while (contador < maxAsientos)
        {
            System.Console.WriteLine($"Visitante #{contador + 1}: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
                break;

            personas.Enqueue(nombre);
            contador++;
        }

        if (personas.Count > 0)
        {
            string atendido = personas.Dequeue();
            System.Console.WriteLine("Asiento asignado a: " + atendido);
            System.Console.WriteLine();
        }

        int porAsignar = personas.Count;
        System.Console.WriteLine("Quedan " + porAsignar + " asientos por asignar");

        cantidadElementos(personas);
        imprimirCola(personas);

    }

    public static void cantidadElementos(Queue<string> cola)
    {
        System.Console.WriteLine($"Total de personas en la cola: {cola.Count}");
        System.Console.WriteLine();
    }

    public static void imprimirCola(Queue<string> cola)
    {
        System.Console.WriteLine("Personas restantes en la cola:");
        foreach (var persona in cola)
        {
            System.Console.WriteLine(persona);
        }
    }
}