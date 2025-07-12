//Crear pila
public class Parentesis //Crear clase principal
{
    public static void run()
    {
        System.Console.WriteLine("Ingrese una expresión:"); //Solicitar al usuario que ingrese una expresión
        string expresion = Console.ReadLine();

        Stack<char> formula = new Stack<char>(); //Crear una pila que almacene los símbolos de apertura
        bool balanceada = true;


        //Recorrer los elementos de la expresión dada
        foreach (var item in expresion)
        {
            if (item == '(' || item == '{' || item == '[')
            {
                formula.Push(item); //Agrega el símbolo de apertura
            }
            else if (item == ')' || item == '}' || item == ']')
            {
                if (formula.Count == 0)
                {
                    balanceada = false;
                    break;
                }

                char apertura = formula.Pop();

                if ((apertura == '(' && item != ')') || (apertura == '{' && item != '}') || (apertura == '[' && item != ']'))
                {
                    balanceada = false;
                    break;
                }
            }
        }

        if (balanceada && formula.Count == 0)
        {
            System.Console.WriteLine("La expresión está correctamente balanceada");
        }
        else
        {
            System.Console.WriteLine("La expresión no está balanceada");
        }
    }
}

