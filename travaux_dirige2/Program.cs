namespace travaux_dirige2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre age");
        int age= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrez votre moyenne");
        double moyenne=Convert.ToDouble(Console.ReadLine());
        if(moyenne>=12 && age<26)
        {
            Console.WriteLine("Admis");
        }
        else
        {
            Console.WriteLine("Refuser");
        }
    }
}
