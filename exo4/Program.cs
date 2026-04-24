namespace exo4;

class Program
{
    static void Main(string[] args)
    {
        
        double prix;
        double euro;
        Console.WriteLine("Entrez votre prix en Franc-CFA");
        prix= Convert.ToDouble(Console.ReadLine());
        euro = prix/655.957;
        Console.WriteLine("Votre prix en Euro est "+ euro);
    }
}
