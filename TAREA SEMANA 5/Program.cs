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
NumerosInversos inversos = new NumerosInversos();
inversos.Ejecutar();

//Mostrar el número de veces de una vocal en una palabra
Vocales vocales = new Vocales();
vocales.Ejecutar();
