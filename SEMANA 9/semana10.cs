public class vacunas //Crear la clase vacunas
{
    public static void run() //Crear un método
    {
        Random random = new Random(); //Utilizar datos randómicos

        HashSet<string> ciudadanos = new HashSet<string>(); //Crear un conjunto de 500 ciudadanos
        for (int i = 0; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        HashSet<string> pfizer = new HashSet<string>(); //Determinar 75 personas que tengan la vacuna Pfizer
        for (int i = 0; i < 75; i++)
            while (pfizer.Count < 75)
            {
                pfizer.Add("Ciudadano " + random.Next(1, 500));
            }

        HashSet<string> astrazeneca = new HashSet<string>(); //Determinar 75 personas que tienen la vacuna AstraZeneca
        for (int i = 0; i < 75; i++)
            while (astrazeneca.Count < 75)
            {
                astrazeneca.Add("Ciudadano " + random.Next(1, 500));
            }
        foreach (var item in pfizer)
        {
            System.Console.WriteLine(item);
        }

        HashSet<string> soloPfizer = new HashSet<string>(); //Mostrar los ciudadanos que solo están vacunados con Pfizer
        soloPfizer.UnionWith(pfizer);
        foreach (var item in soloPfizer)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos vacunados solo con pfizer: " + soloPfizer.Count);

        HashSet<string> soloAstrazeneca = new HashSet<string>(); //Mostrar los ciudadanos que solo están vacunados con AstraZeneca
        soloAstrazeneca.UnionWith(astrazeneca);
        foreach (var item in soloAstrazeneca)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos vacunados solo con Astrazeneca: " + soloAstrazeneca.Count);

        HashSet<string> ambasDosis = new HashSet<string>(pfizer.Intersect(astrazeneca)); //Mostrar los ciudadanos que están vacunados con ambas dosis
        foreach (var item in ambasDosis)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos vacunados con ambas dosis: " + ambasDosis.Count);

        HashSet<string> vacunados = new HashSet<string>(pfizer.Union(astrazeneca)); //Crear un conjunto de ciudadanos vacunados para poder restar los no vacunados

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunados)); //Mostrar los ciudadanos no vacunados
        foreach (var item in noVacunados)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
    }  

}