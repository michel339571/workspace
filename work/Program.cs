namespace work;

class Program
{
    static void Main(string[] args)
    {
        
        double  resultat;
        Console.WriteLine("Entrez un nombre");
        double nombre=Convert.ToDouble(Console.ReadLine());
        for(int i=1; i<=10;i++)
        {
            resultat= nombre*i;
            Console.WriteLine(nombre + "x"+ i + "="+ resultat);
        
        }
    }   

}
