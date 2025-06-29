//Crear una lista que almacene los números del 1 al 10 y mostrarlos en orden inverso
public class NumerosInversos
{
    public void Ejecutar()
    {
        //Lista de números del 1 al 10
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
        //Invertir el orden de la lista
        numeros.Reverse();

        //Mostrar los números en inverso y separados por comas
        System.Console.WriteLine();
        System.Console.WriteLine("========Números en orden inverso del 1 al 10======");
        for (int i = 0; i < numeros.Count; i++)
        {
            if (i < numeros.Count - 1)
                Console.Write(numeros[i] + ", ");
            else
                Console.Write(numeros[i]);
        }
    }
}
