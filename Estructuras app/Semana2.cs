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