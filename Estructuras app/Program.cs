//Crear funciones para calcular el área y el perímetro de dos figuras geométricas (Rectángulo y Círculo)
//CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área del rectángulo donde se requiere datos como base y altura. También se utiliza para calcular el área del círculo y se requiere el radio

Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================\n");

//Cálculo de área y perímetro de rectángulo y círculo
Console.WriteLine("TAREA SEMANA 2\n");


//Ejecuta el programa
Circulo miCirculo = new Circulo(5);
Console.WriteLine("Círculo: ");
Console.WriteLine("Área: " + miCirculo.CalcularArea());
Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

Rectangulo miRectangulo = new Rectangulo(4, 6);
Console.WriteLine("\nRectángulo: ");
Console.WriteLine("Área: " + miRectangulo.CalcularArea());
Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());

