namespace travaux_dirige3;

class Program
{
    static void Main(string[] args)
    {
        int choix;
        Console.WriteLine("Voici le menu");
        Console.WriteLine("1- Eau minérale");
        Console.WriteLine("2- Jus d'orange");
        Console.WriteLine("3- Café");
        Console.WriteLine("Entrez votre choix");
        choix=Convert.ToInt32(Console.ReadLine());
        switch (choix)
        {
            case 1:
                Console.WriteLine("Le prix à payer est 500F");
                break;
            case 2 :
                Console.WriteLine("Le prix à payer est 1000F");
                break;
            case 3 :
                Console.WriteLine("Le prix à payer est 700F");
                break;
            default:
                Console.WriteLine("Choix invalide");
                break;
        
        }
        
    }
}
