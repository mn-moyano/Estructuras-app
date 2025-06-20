using System.ComponentModel;

public class clsEstudiante
{
    private string codigo;
    private string nombre;
    private string[] telefono;
    public clsEstudiante() { }
    public clsEstudiante(string _codigo, string _nombre, string[] _telefonos)
    {
        this.codigo = _codigo;
        nombre = _nombre;
        telefono = _telefonos;
    }
}