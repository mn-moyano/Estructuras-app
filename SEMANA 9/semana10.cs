public class vacunas
{
    public static void run()
    {
        Random random = new Random();

        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 0; i < 75; i++)
        {
            pfizer.Add("persona " + random.Next(1, 500));
        }

        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 0; i < 75; i++)
        {
            astrazeneca.Add("persona " + random.Next(1, 500));
        }
        foreach (var item in pfizer)
        {
            System.Console.WriteLine(item);
        }
        HashSet<string> soloPfizer = new HashSet<string>();
        soloPfizer.UnionWith(pfizer);
        foreach (var item in soloPfizer)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Vacunados solo con pfizer: " + soloPfizer.Count);
    }



    //private static HashSet<string>() (string vacuna, int cantidad){

    //}
    

}