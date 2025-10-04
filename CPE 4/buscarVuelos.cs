public class Vuelo //Crear la clase vuelo que contendrá los datos de origen, destino y precio
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public double Precio { get; set; }

    public Vuelo(string origen, string destino, double precio)//Constructor
    {
        Origen = origen;
        Destino = destino;
        Precio = precio;
    }
}

public class Grafo //Representar un grafo con disccionario de lista adyacente 
{
    Dictionary<string, List<Vuelo>> adj = new Dictionary<string, List<Vuelo>>();//Contendrá los vuelos disponibles

    public void AgregarVuelo(string origen, string destino, double precio) //Método para agregar los vuelos al grafo
    {
        if (!adj.ContainsKey(origen))//Si la ciudad de origen no existe en el diccionario, la creamos
            adj[origen] = new List<Vuelo>();

        adj[origen].Add(new Vuelo(origen, destino, precio));//Agregamos el nuevo vuelo a la lista de esa ciudad
    }

    public Vuelo BuscarVueloMasBarato(string origen, string destino) // Busca en la lista de vuelos, compara los precios y arroja el más barato
    {
        if (adj.ContainsKey(origen))//Verifica si el origen existe en el grafo
        {
            Vuelo masBarato = null;
            foreach (var vuelo in adj[origen])
            {
                if (vuelo.Destino == destino)
                {
                    if (masBarato == null || vuelo.Precio < masBarato.Precio)
                        masBarato = vuelo;
                }
            }
            return masBarato;
        }
        return null;
    }
    public static void run() //Método para ejecutar el programa, pide al usuario ingresar origen y destino, llama a BuscarVueloMasBarato y muestra el resultado
    {
        Grafo grafo = new Grafo();

        grafo.AgregarVuelo("Quito", "Cuenca", 70);
        grafo.AgregarVuelo("Quito", "Guayaquil", 80);
        grafo.AgregarVuelo("Quito", "Manta", 50);
        grafo.AgregarVuelo("Quito", "Cuenca", 90);
        grafo.AgregarVuelo("Quito", "Guayaquil", 100);
        grafo.AgregarVuelo("Guayaquil", "Quito", 110);

        System.Console.WriteLine("====BUSCADOR DE VUELOS====");
        System.Console.WriteLine("Ingrese ciudad de origen: ");
        string origen = Console.ReadLine();

        System.Console.WriteLine("Ingrese ciudad de destino: ");
        string destino = Console.ReadLine();

        Vuelo vuelo = grafo.BuscarVueloMasBarato(origen, destino);

        if (vuelo != null)
        {
            System.Console.WriteLine($"El vuelo más barato de {origen} a {destino} cuesta ${vuelo.Precio}");
        }
        else
        {
            System.Console.WriteLine($"No hay vuelos disponibles de {origen} a {destino}");
        }
    }
}


