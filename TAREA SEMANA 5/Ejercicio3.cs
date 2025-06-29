//Números ganadores de la lotería en orden de menor a mayor
public class Loteria
{
    public void Ejecutar()
    {
        //Números de la lotería
        List<int> numerosGanadores = new List<int>();
        //Ingrese números de la lotería
        System.Console.WriteLine();
        System.Console.WriteLine("=======Lotería Primitiva=====");
        System.Console.WriteLine("Ingrese los 5 números ganadores de la lotería primitiva:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Número " + i + " : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosGanadores.Add(numero);
        }

        //Ordenar los números
        numerosGanadores.Sort();

        //Mostrar los números ordenados
        System.Console.WriteLine("Números ganadores ordenados de menor a mayor:");
        foreach (var numero in numerosGanadores)
        {
            Console.WriteLine(numero);
        }
    }
}