//Crear una Agenda de turnos de pacientes de una clínica
//Crear las clases paciente y turno

using System.Collections.Concurrent;
using System.Net.WebSockets;

public class Paciente
{
    public string Cedula;
    public string Nombre;
    public int Edad;

    //Método para mostrar los datos del paciente
    public Paciente(string _cedula, string _nombre, int _edad)
    {
        Cedula = _cedula;
        Nombre = _nombre;
        Edad = _edad;
    }
}

public class Turno
{
    public Paciente paciente; //Quiere decir que un turno contiene a un paciente
    public string FechaHora; //Fecha y hora del turno
    public Turno(Paciente _paciente, string fechaHora) //Muestra los datos completos del turno
    {
        paciente = _paciente;
        FechaHora = fechaHora;
    }
}