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
// for (int i = 0; i < asignaturas.Count; i++)
// {
//     System.Console.WriteLine("¿Qué nota has sacado en " + asignaturas[i] + "?");
//     double nota = Convert.ToDouble(Console.ReadLine());
//     notas.Add(nota);
// }

// //Imprimir asigantura más nota
// System.Console.WriteLine("====Resultados====");
// for (int i = 0; i < asignaturas.Count; i++)
// {
//     System.Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
// }

// //Números de la lotería
// List<int> numerosGanadores = new List<int>();

// //Ingrese números de la lotería
// System.Console.WriteLine();
// System.Console.WriteLine("=======Lotería Primitiva=====");
// System.Console.WriteLine("Ingrese los 5 números ganadores de la lotería primitiva:");
// for (int i = 1; i <= 5; i++)
// {
//     Console.Write("Número " + i + " : ");
//     int numero = Convert.ToInt32(Console.ReadLine());
//     numerosGanadores.Add(numero);
// }
//Ordenar los números
// numerosGanadores.Sort();

// //Mostrar los números ordenados
// System.Console.WriteLine("Números ganadores ordenados de menor a mayor:");
// foreach (var numero in numerosGanadores)
// {
//     Console.WriteLine(numero);
// }

// //Lista de números del 1 al 10
// List<int> numeros = new List<int>();

// for (int i = 1; i <= 10; i++)
// {
//     numeros.Add(i);
// }

// //Invertir el orden de la lista
// numeros.Reverse();

// //Mostrar los números en inverso y separados por comas
// System.Console.WriteLine();
// System.Console.WriteLine("========Números en orden inverso del 1 al 10======");
// for (int i = 0; i < numeros.Count; i++)
// {
//     if (i < numeros.Count - 1)
//         Console.Write(numeros[i] + ", ");
//     else
//         Console.Write(numeros[i]);
// }

//Palabra y número de vocales
System.Console.WriteLine();
System.Console.WriteLine("===Palabra y número de vocales====");
System.Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine().ToLower();

//Contar vocales
int a = 0, e = 0, i = 0, o = 0, u = 0;

//Mostrar el número de veces que contiene cada vocal de la palabra
foreach (var letra in palabra)
{
    if (letra == 'a') a++;
    else if (letra == 'e') e++;
    else if (letra == 'i') i++;
    else if (letra == 'o') o++;
    else if (letra == 'u') u++;
}

//Mostrar los resultados
System.Console.WriteLine("==Resultados==");
System.Console.WriteLine("A: " + a);
System.Console.WriteLine("E: " + e);
System.Console.WriteLine("I: " + i);
System.Console.WriteLine("O: " + o);
System.Console.WriteLine("U: " + u);