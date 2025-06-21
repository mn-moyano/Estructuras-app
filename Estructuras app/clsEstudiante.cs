using System.ComponentModel;

public class clsEstudiante
{
    public string Nombre { get; set; }
    public double Largo { get; set; }
    public int Edad { get; set; }

    //Constructor
    public clsEstudiante(string _nombre, double _largo, int _edad)
    {
        Nombre = _nombre;
        Largo = _largo;
        Edad = _edad;
    }
    // private string Nombre;
    // public void SetNombre(string _nombre)
    // {
    //     Nombre = _nombre;
    // }
    // public string getNombre()
    // {
    //     return Nombre;
    // }
}