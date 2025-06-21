//Crear funciones para calcular el área y el perímetro de dos figuras geométricas (Rectángulo y Círculo)
//CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área del rectángulo donde se requiere datos como base y altura. También se utiliza para calcular el área del círculo y se requiere el radio
using System.Diagnostics;

Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================\n");
System.Console.WriteLine();


System.Console.WriteLine("Listado de Estudiantes");
System.Console.WriteLine("======================");

int max = 10;
//clsEstudiante estudiante = new clsEstudiante("Madelyn", 23, 3);

clsEstudiante[] estudiantes = new clsEstudiante[10];

clsEstudiante estudiante1 = new clsEstudiante("José", 23, 25);
clsEstudiante estudiante2 = new clsEstudiante("María", 25, 28);
estudiantes[0] = estudiante1;
estudiantes[1] = estudiante2;

//Recorrido del array
// for (int i = 0; i < max; i++) ;
// {
//     System.Console.WriteLine(estudiantes[i].Nombre);
// }

foreach (var item in estudiantes)
{
    System.Console.WriteLine(item.Nombre);
}


// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(estudiantes[i].getNombre());
//  }

// string[] telf = new string[2];
// telf[0] = "0997859163";
// telf[1] = "0989586485";

// clsEstudiante estudiante = new clsEstudiante();
// clsEstudiante estudiante1 = new clsEstudiante("123", "Juana", telf);


//Cálculo de área y perímetro de rectángulo y círculo
// Console.WriteLine("TAREA SEMANA 2\n");


// //Ejecuta el programa
// Circulo miCirculo = new Circulo(5);
// Console.WriteLine("Círculo: ");
// Console.WriteLine("Área: " + miCirculo.CalcularArea());
// Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

// Rectangulo miRectangulo = new Rectangulo(4, 6);
// Console.WriteLine("\nRectángulo: ");
// Console.WriteLine("Área: " + miRectangulo.CalcularArea());
// Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
// System.Console.WriteLine();

// //Ejecuta semana3
// Estudiante estudiante = new Estudiante("a1", "María Elena", "Rocero Sánchez", "Santo Domingo", new string[] { "0997558111", "0987425345", "0998756312" });
// System.Console.WriteLine(estudiante.getEstudiante());
// System.Console.WriteLine(estudiante.getTelefonos());

// string[] telefonos = estudiante.getTelefonos();
// System.Console.WriteLine("El teléfono 1 es: " + telefonos[0]);
// System.Console.WriteLine("El teléfono 2 es: " + telefonos[1]);
// System.Console.WriteLine("El teléfono 3 es: " + telefonos[2]);
