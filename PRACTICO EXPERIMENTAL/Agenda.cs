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
        
    }
}    