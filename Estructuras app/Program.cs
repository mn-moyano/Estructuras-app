Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================");
Console.WriteLine();

System.Console.WriteLine("El perimetro de un cuadrado de lado 5 es " + perimetroCuadrado(5));
System.Console.WriteLine("El área de un cuadrado de lado 5 es " + areaCuadrado(5));



//int a = 3;
//int b = 4;
//Console.WriteLine(a + b);
//System.Console.WriteLine(suma(3, 4));
//System.Console.WriteLine(suma(4, 7));
//System.Console.WriteLine("La suma es: " + suma(2, 1));
//System.Console.WriteLine("La suma de " + a + " y " + b + " es: " + suma(a, b));

//Crear una función de suma
//int suma (int a, int b)
//{
//    return a + b;
//}


//Función para calcular el perímetro de un cuadrado o rectángulo
double perimetroCuadrado(double lado)
{
    return lado + lado + lado + lado;
}
//Función para calcular el área de un cuadrado
double areaCuadrado(double lado)
{
    return lado * lado;
}