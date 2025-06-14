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

        for (int i = 0; i < 3 && i < _telefonos.Length; i++)
        {
            telefonos[i] = _telefonos[i];
        }
    }

    public string getEstudiante()
    {
        return $"Estudiante : {id}\nNombres: {nombres}\nApellidos: {apellidos}\nDirección: {direccion}";
    }

    public string[] getTelefonos()
    {
        return telefonos;
    }
}

    

