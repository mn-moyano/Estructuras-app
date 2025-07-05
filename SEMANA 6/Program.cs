Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("======================");
System.Console.WriteLine();
ListaEnlazada lista = new ListaEnlazada();
Random rnd = new Random();

for (int i = 0; i < 50; i++)
{
    lista.AgregarAlFinal(rnd.Next(1, 1000));
}

System.Console.WriteLine("Lista inicial");
lista.Mostrar();

System.Console.WriteLine("Ingrese el valor mínimo del rango: ");
int minimo = int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese el valor máximo del rango: ");
int maximo = int.Parse(Console.ReadLine());

lista.EliminarRango(minimo, maximo);

System.Console.WriteLine("Lista 2: Luego de eliminar los Nodos fuera de rango ");
lista.Mostrar(); 