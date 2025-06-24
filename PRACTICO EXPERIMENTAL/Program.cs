//Programa que da marcha a la agenda de la clínica
System.Console.WriteLine("Agenda de Turnos de Pacientes");
System.Console.WriteLine("=============================");

int max = 10;
Turno[] turnos = new Turno[max];

//Crear pacientes y turnos
Paciente paciente1 = new Paciente("1708402449", "Rodrigo", 58);
Paciente paciente2 = new Paciente("1201524856", "Rosa", 25);
Paciente paciente3 = new Paciente("2300048952", "Madelyn", 28);

Turno turno1 = new Turno(paciente1, "2025-07-10 9:00");
Turno turno2 = new Turno(paciente2, "2025-07-12 14:00");
Turno turno3 = new Turno(paciente3, "2025-07-12 16:30");

//Insertar en el arreglo
turnos[0] = turno1;
turnos[1] = turno2;
turnos[2] = turno3;

//Mostrar los turnos
System.Console.WriteLine();
System.Console.WriteLine("Listado de Turnos");
System.Console.WriteLine("=================");

bool continuar = true;
int i = 0;

while (continuar)
{
    if (turnos[i] != null)
    {
        System.Console.WriteLine("Paciente: " + turnos[i].paciente.Nombre + " Cedula: " + turnos[i].paciente.Cedula + " Edad: " + turnos[i].paciente.Edad + " Fecha y Hora: " + turnos[i].FechaHora);
        i++;
    }
    else
    {
        continuar = false;
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Turno buscado");
System.Console.WriteLine("=============");
//Buscar turno por cédula
continuar = true;
bool encontrado = false;
string cedulaConsulta = "2300048952";

//Reiniciar indice
i = 0;
while (continuar)
{
    if (turnos[i] != null)
    {
        if (turnos[i].paciente.Cedula == cedulaConsulta)
        {
            encontrado = true;
            continuar = false;
        }
        else
        {
            i++;
        }
    }
    else
    {
        continuar = false;
    }
}

if (encontrado)
{
    System.Console.WriteLine("Turno para la cédula " + cedulaConsulta + " encontrado.");
}
else
{
    System.Console.WriteLine("Turno para la cédula " + cedulaConsulta + " no encontrado.");
}