public class Asignaturas
{
    public void Ejecutar()
    {
        //Crear una lista de asiganturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        System.Console.WriteLine("===Asignaturas===");
        //Imprimir la lista
        foreach (var asigantura in asignaturas)
        {
            System.Console.WriteLine("Yo estudio " + asigantura);
        }
    } 
}