namespace exo1Boucle;

class Program
{
    static void Main(string[] args)
    {
        double note;
        do
        {
            Console.WriteLine("Entrez une note 0 et 10");
            note=Convert.ToDouble(Console.ReadLine());
            if (note<0 || note>10)
            {
                Console.WriteLine("Recommence connard");
            }
        }while(note<0 || note>10);
        Console.WriteLine(" Merci ! Note Enregistrée : " + note );
    }
}
