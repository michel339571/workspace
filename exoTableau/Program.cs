using System.Security.AccessControl;

namespace exoTableau;

class Program
{
    static void Main(string[] args)
    {
       int [] age;
       int nombreEtudiant;
       Console.WriteLine("Combien d'étudiants il y a?");
       nombreEtudiant=Convert.ToInt32(Console.ReadLine());
       age= new int[nombreEtudiant];
       for(int i=0; i<nombreEtudiant; i++)
        {
            Console.WriteLine("Entrez l'age de l'étudiant " + (i+1));
            age[i]=Convert.ToInt32(Console.ReadLine());   
        }
        Console.WriteLine("Les ages des étudiants sont ");
        for(int i=0; i < age.Length; i++)
            {
                Console.WriteLine("L'étudiant n° " + (i+1) + " a "+ age[i] + " ans ");
            }
            Console.ReadLine();
    }
}
