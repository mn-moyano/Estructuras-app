//Mostrar el número de veces de una vocal en una palabra
public class Vocales
{
    public void Ejecutar()
    {
        //Palabra y número de vocales
        System.Console.WriteLine();
        System.Console.WriteLine("===Palabra y número de vocales====");
        System.Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        //Contar vocales
        int a = 0, e = 0, i = 0, o = 0, u = 0;

        //Mostrar el número de veces que contiene cada vocal de la palabra
        foreach (var letra in palabra)
        {
            if (letra == 'a') a++;
            else if (letra == 'e') e++;
            else if (letra == 'i') i++;
            else if (letra == 'o') o++;
            else if (letra == 'u') u++;
        }
        //Mostrar los resultados
        System.Console.WriteLine("==Resultados==");
        System.Console.WriteLine("A: " + a);
        System.Console.WriteLine("E: " + e);
        System.Console.WriteLine("I: " + i);
        System.Console.WriteLine("O: " + o);
        System.Console.WriteLine("U: " + u);
    }
}