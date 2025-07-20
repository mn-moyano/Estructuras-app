//Asignar 30 asientos en una atracción
public class Colas
{
    public static void run()
    {
        Queue<string> personas = new Queue<string>();
        const int maxAsientos = 30;

        System.Console.WriteLine("Simulación automática: Asigación de 30 asientos en orden de llegada.");
        System.Console.WriteLine();

        for (int i = 1; i <= maxAsientos; i++)
        {
            personas.Enqueue("Persona" + i);
        }

        cantidadElementos(personas);
        System.Console.WriteLine("Asignando asientos...");
        System.Console.WriteLine();

        int asiento = 1;
        while (personas.Count > 0)
        {
            string atendido = personas.Dequeue();
            System.Console.WriteLine($"Asiento #{asiento} asignado a: {atendido}");
            asiento++;
        }

        System.Console.WriteLine("Todos los asientos han sido asignados.");

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