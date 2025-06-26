public class AgendaTurnos
{
    public Paciente[] Turnos { get; set; }
    public AgendaTurnos(int maxTurnos)
    {
        Turnos = new Paciente[maxTurnos];
    }

    public void AgendarTurno(Paciente paciente, int posicion)
    {
        Turnos[posicion] = paciente;
    }

    public void ImprimirTurnos()
    {
        System.Console.WriteLine("Agenda de Turnos");
        System.Console.WriteLine("================");

        for (int i = 0; i < Turnos.Length; i++)
        {
            if (Turnos[i] != null)
            {
                System.Console.WriteLine("Turno asignado a: " + Turnos[i].Nombre + Turnos[i].Cedula + Turnos[i].Edad);
            }
        }
    }
}    