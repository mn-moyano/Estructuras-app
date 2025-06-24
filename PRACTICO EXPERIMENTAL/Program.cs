//Programa que da marcha a la agenda de la clínica
System.Console.WriteLine("Agenda de Turnos de Pacientes");
System.Console.WriteLine("=============================");

int max = 10;
Turno[] turnos = new Turno[max];

//Crear pacientes y turnos
Paciente paciente1 = new Paciente("1708402449", "Rodrigo", 58);
Paciente paciente2 = new Paciente("1201524856", "Rosa", 25);
Paciente paciente3 = new Paciente("2300048952", "Madelyn", 28);

