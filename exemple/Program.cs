namespace exemple;

class Program
{
    static void Main(string[] args)
    {
        int niveauEssence=5;
        while (niveauEssence>0)
        {
            Console.WriteLine("La voiture roule........ Essence restante :" + niveauEssence);
            niveauEssence--;
        }
        Console.WriteLine("Panne sèche");
    }
}
