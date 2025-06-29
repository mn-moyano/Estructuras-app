//Crear una lista de asignaturas y preguntar por las notas
public class NotasAsignaturas
{
    public void Ejecutar()
    {
        //Crear una lista de asiganturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        //Crear lista de notas
        List<double> notas = new List<double>();

        System.Console.WriteLine("===Ingreso de Notas===");
        //Ingrese nota
        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine("¿Qué nota has sacado en " + asignaturas[i] + "?");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);
        }
        //Imprimir asigantura más nota
        System.Console.WriteLine("====Resultados====");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
        }
    }
}