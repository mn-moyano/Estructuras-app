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