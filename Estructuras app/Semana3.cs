//Tarea Semana 3
using System.Runtime.CompilerServices;

public class Estudiante
{
    private string id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos = new string[3];
    //genero el constructor
    public Estudiante(string _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        telefonos = new string[3];
        telefonos = _telefonos;
    }

    public string getEstudiante()
    {
        return id;
    }

    public string[] getTelefonos()
    {
        return telefonos;
    }
}

    

