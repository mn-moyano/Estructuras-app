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
    public void MostrarTurno() //Muestra los datos completos del turno
    {
        System.Console.WriteLine("====Turno====");
        paciente.MostrarDatos();
        System.Console.WriteLine($"Fecha y hora del turno: {FechaHora}");
    }
}

class Agenda
{
    private turno[] turnos = new turno[10]; //Arreglo de 10 turnos máximo
    private int contador = 0; //Lleva la cuenta de los turnos ingresados

    //Agregar turnos si hay disponibilidad
    public void AgregarTurno(turno nuevoTurno)
    {
        if (contador < turnos.Length)
        {
            turnos[contador] = nuevoTurno;
            contador++;
            System.Console.WriteLine("Turno agregado correctamente.");
        }
        else
        {
            System.Console.WriteLine("Error, no se puede agendar turno. Agenda llena.");
        }
    }

    //Muestra los turnos agendados
    public void MostrarTurnos()
    {
        System.Console.WriteLine("\n Lista de Turnos:");
        if (contador == 0)
        {
            System.Console.WriteLine("No hay turnos agendados.");
            return;
        }
        for (int i = 0; i < contador; i++)
        {
            turnos[i].MostrarTurno();
        }
    }

    //Buscar turnos por número de cédula

    public void BuscarPorCedula(string cedula)
    {
        System.Console.WriteLine();
    }
}