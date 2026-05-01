namespace systemesecurisé;

class Program
{
    static void Main(string[] args)
    {
       int choix;
        Console.WriteLine("Entrez votre choix");
       
        do
        {
        
            choix=Convert.ToInt32(Console.ReadLine());
            if (choix > 3 || choix==0)
            {
                Console.WriteLine("Retapez le choix");
            }
            
        } while (choix > 3);
            switch (choix)
            {
                case 1:
                    Console.WriteLine("Vous avez choisi C#");
                    break;
                case 2:
                    Console.WriteLine("Vous avez choisi Java");
                    break;
                case 3:
                    Console.WriteLine("Vous avez choisi python");
                    break;     
            }
        
        
    }
}
