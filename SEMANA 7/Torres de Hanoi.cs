//Crear pila
public class TorresDeHanoi
{
    Stack<int> discos;
    string nombre;

    TorresDeHanoi(string nombre)
    {
        this.nombre = nombre;
        discos = new Stack<int>();
    }
    public void MoverDiscoDesde(TorresDeHanoi origen)
    {
        int disco = origen.discos.Pop();
        discos.Push(disco);
        System.Console.WriteLine("$Mover disco {disco} desde {origen.nombre} hacia {nombre}");
    }

    public void Mostrar()
    {
        System.Console.WriteLine($"{nombre}: {string.Join(" , ", discos.ToArray())}");
    }
    public Stack<int> ObtenerPila() => discos;

    public static void run()
    {
        int cantidadDiscos = 3;
        var torreA = new TorresDeHanoi("A");
        var torreB = new TorresDeHanoi("B");
        var torreC = new TorresDeHanoi("C");

        for (int i = cantidadDiscos; i >= 1; i--)
        {
            torreA.discos.Push(i);
        }
        System.Console.WriteLine("Pasos para resolver las Torres de Hanoi: ");
        MostrarTorres(torreA, torreB, torreC);
        Resolver(cantidadDiscos, torreA, torreB, torreC);
        System.Console.WriteLine();
        System.Console.WriteLine("Estado final");
        MostrarTorres(torreA, torreB, torreC);
    }

    private static void Resolver(int n, TorresDeHanoi origen, TorresDeHanoi auxiliar, TorresDeHanoi destino)
    {
        if (n == 1)
        {
            destino.MoverDiscoDesde(origen);
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            Resolver(n - 1, origen, destino, auxiliar);
            destino.MoverDiscoDesde(origen);
            MostrarTorres(origen, auxiliar, destino);
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }

    private static void MostrarTorres(TorresDeHanoi a, TorresDeHanoi b, TorresDeHanoi c)
    {
        a.Mostrar();
        b.Mostrar();
        c.Mostrar();
        System.Console.WriteLine("============\n");
    }
}