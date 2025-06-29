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

//Imprimir asigantura más nota
System.Console.WriteLine("====Resultados====");
for (int i = 0; i < asignaturas.Count; i++)
{
    System.Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
}

//Números de la lotería
List<int> numerosGanadores = new List<int>();

//Ingrese números de la lotería
System.Console.WriteLine();
System.Console.WriteLine("=======Lotería Primitiva=====");
System.Console.WriteLine("Ingrese los 5 números ganadores de la lotería primitiva:");
for (int i = 1; i <= 5; i++)
{
    Console.Write("Número " + i + " : ");
    int numero = Convert.ToInt32(Console.ReadLine());
    numerosGanadores.Add(numero);
}
//Ordenar los números
numerosGanadores.Sort();

//Mostrar los números ordenados
System.Console.WriteLine("Números ganadores ordenados de menor a mayor:");
foreach (var numero in numerosGanadores)
{
    Console.WriteLine(numero);
}

