System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");

//Mostrar Asignaturas
Asignaturas asignaturas = new Asignaturas();
asignaturas.Ejecutar();

//Mostrar asignaturas y pedir notas
NotasAsignaturas notas = new NotasAsignaturas();
notas.Ejecutar();

//Mostrar números ganadores de la Lotería
Loteria loteria = new Loteria();
loteria.Ejecutar();

//Mostrar los números del 1 al 10 en orden inverso


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
