//Implementar el método buscar en la clase lista y retornar el número de veces que se encuentra el dato dentro de la lista.
//Crear la clase Nodo
public class Nodo2
{
    public int Dato;
    public Nodo2 Siguiente;

    public Nodo2(int _dato)
    {
        Dato = _dato;
        Siguiente = null;
    }
}

//Crear la clase lista enlazada
public class ListaEnlazada2
{
    public Nodo2 Cabeza;
    public void AgregarAlFinal(int _dato)
    {
        Nodo2 nuevo = new Nodo2(_dato);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo2 actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    //Mostrar lista original
    public void Mostrar()
    {
        Nodo2 actual = Cabeza;
        while (actual != null)
        {
            System.Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        System.Console.WriteLine("null");
    }

//Método para buscar datos en la lista
    public ListaEnlazada2 BuscarDatoLista(int valorBuscado)
    {
        Nodo2 actual = Cabeza;
        ListaEnlazada2 encontrados = new ListaEnlazada2();
        int contador = 0;
//Contar cuantas veces existe un dato en la lista
        while (actual != null)
        {
            if (actual.Dato == valorBuscado)
            {
                encontrados.AgregarAlFinal(actual.Dato);
                contador++;
            }
            actual = actual.Siguiente;
        }

        if (contador == 0)
        {
            System.Console.WriteLine($"El valor {valorBuscado} no fue encontrado en la lista.");
        }
        else
        {
            System.Console.WriteLine($"El valor {valorBuscado} fue encontrado {contador} veces.");
            System.Console.WriteLine("Elementos encontrados: ");
            encontrados.Mostrar();
        }

        return encontrados;
    }
}