namespace travaux_dirige;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre vitesse actuelle");
        double vitesse=Convert.ToDouble(Console.ReadLine());
        if(vitesse>120)
        {
           Console.WriteLine("Excès de vitesse, amande de 50000 FCFA");

        }
        else if(vitesse<40)
        {
            Console.WriteLine("Vitesse est trop basse: Danger");
        }
        else
        {
            Console.WriteLine("Vitesse normale, Bonne conduite");
        }
    }
}
