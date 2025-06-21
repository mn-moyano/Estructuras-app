//Crear una Agenda de turnos de pacientes de una clínica
//Crear las clases paciente y turno

using System.Collections.Concurrent;
using System.Net.WebSockets;

class Paciente
{
    public string Cedula;
    public string Nombre;
    public int Edad;

    //Método para mostrar los datos del paciente
    public void MostrarDatos()
    {
        System.Console.WriteLine($"Cédula: {Cedula}, Nombre: {Nombre}, Edad: {Edad}");
    }
}

class turno
{
    public Paciente paciente; //Quiere decir que un turno contiene a un paciente
    public string FechaHora; //Fecha y hora del turno
    public void MostrarTurno()
    {
        System.Console.WriteLine("====Turno====");
        paciente.MostrarDatos();
        System.Console.WriteLine($"Fecha y hora del turno: {FechaHora}");
    }
}

class Agenda
{
    
}