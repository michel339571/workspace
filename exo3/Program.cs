namespace exo3;

class Program
{
    static void Main(string[] args)
    {
        double longueur;
        double largeur;
        double surface;
        Console.WriteLine("Entrez la Longueur de la surface");
        longueur = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Entrez la largeur de la surface");
        largeur = Convert.ToDouble(Console.ReadLine());
        surface = longueur*largeur;
        Console.WriteLine("La surface du batiment est "+surface);
    }
}
