System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");

//Crear una lista de asiganturas
List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

//Crear lista de notas
List<double> notas = new List<double>();

//Imprimir la lista
 foreach (var asigantura in asignaturas)
 {
    System.Console.WriteLine("Yo estudio " + asigantura);
 }

//Ingrese nota
for (int i = 0; i < asignaturas.Count; i++)
{
    System.Console.WriteLine("¿Qué nota has sacado en " + asignaturas[i] + "?");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas.Add(nota);
}

System.Console.WriteLine("====Resultados====");
for (int i = 0; i < asignaturas.Count; i++) 
{
    System.Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
}