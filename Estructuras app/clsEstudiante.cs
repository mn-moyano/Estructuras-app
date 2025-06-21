using System.ComponentModel;

public class clsEstudiante
{
    private string Nombre;
    public void SetNombre(string _nombre)
    {
        Nombre = _nombre;
    }
    public string getNombre()
    {
        return Nombre;
    }
}