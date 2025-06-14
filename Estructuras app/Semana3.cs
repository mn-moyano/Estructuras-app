//Tarea Semana 3
using System.Runtime.CompilerServices;

public class Asignatura
{
    private string nombre;
    private double[] notas;
    //genero el constructor
    public Asignatura(string _nombre, double[] _notas)
    {
        nombre = _nombre;
        notas = new double[3];
        notas = _notas;
    }

    public string getAsignatura()
    {
        return nombre;
    }

    public double[] getNotas()
    {
        return notas;
    }
}

