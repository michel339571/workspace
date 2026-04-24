namespace exo2;

class Program
{
    static void Main(string[] args)
    {
      int nombre, eleve, part, reste ;
      Console.WriteLine("Entrez le nombre total des oranges");
      nombre = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Le nombre d'élève");
      eleve = Convert.ToInt32(Console.ReadLine());
      part = nombre/eleve;
      reste = nombre%eleve;
      Console.WriteLine("Chaque élève reçoit  "+part);
      Console.WriteLine("Il reste "+reste);

    }
}
