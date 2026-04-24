namespace travail;

class Program
{
    static void Main(string[] args)
    {
        int month;
        string season = "";
        Console.WriteLine("Entrez un numéro");
        month= Convert.ToInt32(Console.ReadLine());
        switch(month)
        {
            case 1:
            Console.WriteLine("Winter");
            break;
            case 2 :
            Console.WriteLine("Winter");
            break;
            case 3:
            Console.WriteLine("Spring");
            break;
            case 4:
            Console.WriteLine("Spring");
            break;
            case 5:
            Console.WriteLine("Spring");
            break;
            case 6:
            Console.WriteLine("Summer");
            break;
            case 7:
            Console.WriteLine("Summer");
            break;
            case 8:
            Console.WriteLine("Summer");
            break;
            case 9:
            Console.WriteLine("Autumn");
            break;
            case 10:
            Console.WriteLine("Autumn");
            break;
            case 11:
            Console.WriteLine("Autumn");
            break;
            case 12:
            Console.WriteLine("Winter");
            break;
            default:
                Console.WriteLine("Indéfini");
                break;
        }
        
        Console.WriteLine(season);
    }
}
