//Crear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente.
public class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int _dato)
    {
        Dato = _dato;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;
    public void AgregarAlFinal(int _dato)
    {
        Nodo nuevo = new Nodo(_dato);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }
    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            System.Console.WriteLine(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        System.Console.WriteLine("null");
    }
    public void EliminarRango(int minimo, int maximo)
    {
        while (Cabeza != null && (Cabeza.Dato < minimo || Cabeza.Dato > maximo))
        {
            Cabeza = Cabeza.Siguiente;
        }
        if (Cabeza == null) return;

        Nodo actual = Cabeza.Siguiente;
        Nodo anterior = Cabeza;

        while (actual != null)
        {
            if (actual.Dato < minimo || actual.Dato > maximo)
            {
                anterior.Siguiente = actual.Siguiente;
            }
            else
            {
                anterior = actual;
            }
            actual = actual.Siguiente;
        }
    }
}