public class Nodo //Almacenará un título de revista
{
    public string Valor; //Será el título de la revista
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(string valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

public class ArbolBinarioBusqueda //Crear el árbol binario de búsqueda
{
    private Nodo raiz;

    public void Insertar(string valor) //Insertar un título en el árbol binario de búsqueda
    {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, string valor) //Inserción recursiva, es decir, si el nodo es null se crea uno nuevo, sino decide a que rama ir según el alfabeto
    {
        if (nodo == null)
            return new Nodo(valor);
        if (string.Compare(valor, nodo.Valor, true) < 0)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (string.Compare(valor, nodo.Valor, true) > 0)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
        return nodo;
    }

    public bool Buscar(string valor) //Busca un título en el árbol
    {
        return BuscarRecursivo(raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, string valor)
    {
        if (nodo == null) //No encontrado
        {
            return false;
        }
        if (nodo.Valor.Equals(valor, StringComparison.OrdinalIgnoreCase)) //true
        {
            return true;
        }
        else if (string.Compare(valor, nodo.Valor, true) < 0) //buscar en izquierdo
        {
            return BuscarRecursivo(nodo.Izquierdo, valor);
        }
        else //Buscar en derecho
        {
            return BuscarRecursivo(nodo.Derecho, valor);
        }
    }
}
public class Catalogo //Creamos la clase catálogo
{
    public static void run()//Creamos el método que ejecuta el programa
    {
        List<string> revistas = new List<string> { "Forbes", "People", "Time", "Caras", "Vistazo",
            "Nature", "The Economist", "National Geographic", "Chic", "Glow" };//Creamos una lista de revistas

        ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda(); //Construimos el árbol con los títulos del catálogo

        foreach (var item in revistas)
        {
            arbol.Insertar(item);
        }
        int opcion = -1; //Controla el ciclo del menú
        while (opcion != 0) //Bucle que se ejecuta hasta salir
        {
            System.Console.WriteLine("=====Catálogo de Revistas====="); //Menú interactivo
            System.Console.WriteLine("**************Menú************");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("0. Salir");
            System.Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); //Opcion para leer desde la consola

            if (opcion == 1)//Realiza la búsqueda de la revista
            {
                System.Console.WriteLine("Ingrese el título de la revista a buscar: ");
                string titulo = Console.ReadLine();

                bool encontrado = arbol.Buscar(titulo);//Llamamos a la función de búsqueda recursiva
                if (encontrado)
                {
                    System.Console.WriteLine("Encontrado");
                }
                else
                {
                    System.Console.WriteLine("No encontrado");
                }
            }
            else if (opcion == 0) //Salimos del programa
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