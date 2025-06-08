//Crear funciones para calcular el área y el perímetro de dos figuras geométricas (Rectángulo y Círculo)
//CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área del rectángulo donde se requiere datos como base y altura. También se utiliza para calcular el área del círculo y se requiere el radio
using System;
namespace PracticaFiguras
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
            Console.WriteLine("=============================");
            Console.WriteLine();
            //Cálculo de área y perímetro de rectángulo y círculo
            Console.WriteLine("TAREA SEMANA 2");
            Console.WriteLine();
            //Ejecuta el programa
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Círculo: ");
            Console.WriteLine("Área: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

            Rectangulo miRectangulo = new Rectangulo(4, 6);
            Console.WriteLine("\nRectángulo: ");
            Console.WriteLine("Área: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());

        }
    }
    class Circulo //Crear la clase circulo
    {
        private double radio; //Colocar datos
        public Circulo(double r)
        {
            radio = r;
        }
        public double CalcularArea() //Colocar la función
        {
            return Math.PI * radio * radio;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
    class Rectangulo //Crear la clase Rectángulo
    {
        private double largo;
        private double ancho; //Colocar los datos
        public Rectangulo(double l, double a)
        {
            largo = l;
            ancho = a;
        }
        public double CalcularArea() //Utilizar las funciones
        {
            return largo * ancho;
        }
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    } 
}