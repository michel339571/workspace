namespace juste_prix;

class Program
{
    static void Main(string[] args)
    {
        double nombreMagique=50, saisie;
        Console.WriteLine("Dévinez le nombre magique");
        saisie= Convert.ToDouble(Console.ReadLine());
        while(saisie != nombreMagique)
        {
            if (saisie < nombreMagique)
            {
                Console.WriteLine("C'est plus");
            }
            else
            {
                Console.WriteLine("C'est Moins");
            }
            saisie=Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Bravo vous avez trouvé le nombre magique");
    }
}
