public class vacunas
{
    public static void run()
    {
        Random random = new Random();

        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 0; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 0; i < 75; i++)
            while (pfizer.Count < 75)
            {
                pfizer.Add("Ciudadano " + random.Next(1, 500));
            }

        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 0; i < 75; i++)
            while (astrazeneca.Count < 75)
            {
                astrazeneca.Add("Ciudadano " + random.Next(1, 500));
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
        System.Console.WriteLine("Ciudadanos vacunados solo con pfizer: " + soloPfizer.Count);

        HashSet<string> soloAstrazeneca = new HashSet<string>();
        soloAstrazeneca.UnionWith(astrazeneca);
        foreach (var item in soloAstrazeneca)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos vacunados solo con Astrazeneca: " + soloAstrazeneca.Count);

        HashSet<string> ambasDosis = new HashSet<string>(pfizer.Intersect(astrazeneca));
        foreach (var item in ambasDosis)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos vacunados con ambas dosis: " + ambasDosis.Count);

        HashSet<string> vacunados = new HashSet<string>(pfizer.Union(astrazeneca));

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunados));
        foreach (var item in noVacunados)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
    }  

}