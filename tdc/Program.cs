namespace tdc;

class Program
{
    static void Main(string[] args)
    {
        double nombre, somme=0, moyenne;
        for(int i=1; i<=5; i++)
        {
             Console.WriteLine("Entrez un nombre");
             nombre=Convert.ToDouble(Console.ReadLine());
             somme = somme + nombre ; 
        }
        moyenne= somme/5;
        Console.WriteLine("La moyenne est: " + moyenne);
        if(moyenne>=10)
        {
            Console.WriteLine("Vous etes admis");
        }
        else
        {
            Console.WriteLine("Ajourné");
        }
    }
}
