namespace Nouveau_dossier;

class Program
{
    static void Main(string[] args)
    {
        int a ;
        Console.WriteLine( "Entrez votre nombre") ;
        a = Convert.ToInt32(Console.ReadLine()) ;
        
        if(a % 2 == 0)
        {
            Console.WriteLine("le nombre est pair" + a) ;
        }
        else
        {
            Console.WriteLine("a n'est pas pair " + a) ;
        }


    }
}
