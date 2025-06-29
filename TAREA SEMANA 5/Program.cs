System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");

//Crear una lista de asiganturas
List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

//Imprimir la lista
foreach (var asigantura in asignaturas)
{
     System.Console.WriteLine("Yo estudio " + asigantura);
}
