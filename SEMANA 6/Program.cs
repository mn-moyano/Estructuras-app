Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("======================");
System.Console.WriteLine();
//Crear el programa que ejecuta las acciones del ejercicio1
ListaEnlazada lista = new ListaEnlazada(); //Crear la lista enlazada con 50 números aleatorios desde 1 a 1000
Random rnd = new Random();

for (int i = 0; i < 50; i++) //Llenar la lista
{
    lista.AgregarAlFinal(rnd.Next(1, 1000));
}

//Mostrar la lista inicial (imprimir)
System.Console.WriteLine("Lista inicial");
lista.Mostrar();

//Leer el rango desde teclado
System.Console.WriteLine("Ingrese el valor mínimo del rango: ");
int minimo = int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese el valor máximo del rango: ");
int maximo = int.Parse(Console.ReadLine());

//Eliminar nodos fuera de rango
lista.EliminarRango(minimo, maximo);

//Mostrar la nueva lista después de eliminar nodos
System.Console.WriteLine("Lista 2: Luego de eliminar los Nodos fuera de rango ");
lista.Mostrar(); 