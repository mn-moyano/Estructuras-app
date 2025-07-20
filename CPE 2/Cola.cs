//Asignar 30 asientos en una atracción
public class Colas //Crear la clase colas
{
    public static void run()
    {
        Queue<string> personas = new Queue<string>(); //Agregar personas a la cola (máximo 30)
        const int maxAsientos = 30;

        System.Console.WriteLine("Simulación: Asigación de 30 asientos en orden de llegada.");
        System.Console.WriteLine("Ingrese los nombres de los visitantes en orden de llegada (escriba 'fin' para terminar antes de los 30):");

        int contador = 0;
        while (contador < maxAsientos)
        {
            System.Console.WriteLine($"Visitante #{contador + 1}: "); //Número de visitante
            string nombre = Console.ReadLine(); //Ingresar nombre desde la consola

            if (nombre.ToLower() == "fin") //Usar una palabra para finalizar antes de llegar a 30
                break;

            personas.Enqueue(nombre);
            contador++;
        }

        System.Console.WriteLine("Iniciando proceso de asignación de asientos...");
        System.Console.WriteLine();

        while (personas.Count > 0)
        {
            venta(personas);
        }
    }

    public static void venta(Queue<string> cola)
    {
        if (cola.Count > 0)
        {
            string persona = cola.Dequeue();
            System.Console.WriteLine($"Asiento asignado a: {persona}");
            Thread.Sleep(2000); //Espera de 2 segundos
        }

        System.Console.WriteLine();
        cantidadElementos(cola);
        imprimirCola(cola);
    }

    public static void cantidadElementos(Queue<string> cola)
    {
        System.Console.WriteLine("Existen " + cola.Count + " personas en la cola"); //Cantidad de personas en cola
        System.Console.WriteLine();
    }

    public static void imprimirCola(Queue<string> cola)
    {
        if (cola.Count == 0)
        {
            System.Console.WriteLine("No hay más personas en la cola");
            return;
        }

        System.Console.WriteLine("Personas restantes en la cola:"); //Muestra las personas en la colalo
        foreach (var persona in cola)
        {
            System.Console.WriteLine("- " + persona);
        }
        System.Console.WriteLine();
    }
}