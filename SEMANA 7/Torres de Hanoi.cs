//Crear pila
public class TorresDeHanoi
{
    Stack<int> discos; //Pila de discos
    string nombre; //nombre de la pila

    TorresDeHanoi(string nombre)
    {
        this.nombre = nombre;
        discos = new Stack<int>();
    }
    //Método para mover un disco de una torre a otra
    public void MoverDiscoDesde(TorresDeHanoi origen)
    {
        int disco = origen.discos.Pop(); //Toma el disco de la cima de la torre origen
        discos.Push(disco); //Coloca el disco en esta torre
        System.Console.WriteLine($"Mover disco {disco} desde {origen.nombre} hacia {nombre}");
    }
//Método para mostar el contenido de esta torre
    public void Mostrar()
    {
        System.Console.WriteLine($"{nombre}: {string.Join(" , ", discos.ToArray())}");
    }
    //Acceso público a la pila
    public Stack<int> ObtenerPila() => discos;

//Método estático que contiene toda la lógica e inicia y ejecuta
    public static void run()
    {
        int cantidadDiscos = 3;
        var torreA = new TorresDeHanoi("A"); //Crear las 3 torres
        var torreB = new TorresDeHanoi("B");
        var torreC = new TorresDeHanoi("C");

//Llenar la torre A con los discos del más grande al más pequeño
        for (int i = cantidadDiscos; i >= 1; i--)
        {
            torreA.discos.Push(i);
        }
        System.Console.WriteLine("Pasos para resolver las Torres de Hanoi: ");
        System.Console.WriteLine("=========================================");
        MostrarTorres(torreA, torreB, torreC); //Muestra el estado inicial
        Resolver(cantidadDiscos, torreA, torreB, torreC); //Llama al algoritmo recursivo
        System.Console.WriteLine("Estado final");
        MostrarTorres(torreA, torreB, torreC);
    }
//Método recursivo para resolver el problema de las torres
    private static void Resolver(int n, TorresDeHanoi origen, TorresDeHanoi auxiliar, TorresDeHanoi destino)
    {
        if (n == 1)
        {
            destino.MoverDiscoDesde(origen);
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            Resolver(n - 1, origen, destino, auxiliar); //mover n-1 discos a la torre auxiliar
            destino.MoverDiscoDesde(origen); //mover el disco restante al destino
            MostrarTorres(origen, auxiliar, destino);
            Resolver(n - 1, auxiliar, origen, destino); //mover los n-1 discos desde auxiliar al destino
        }
    }
//Mostrar el estado actual de las tres torres
    private static void MostrarTorres(TorresDeHanoi a, TorresDeHanoi b, TorresDeHanoi c)
    {
        a.Mostrar();
        b.Mostrar();
        c.Mostrar();
        System.Console.WriteLine("============\n");
    }
}