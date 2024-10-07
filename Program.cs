using System.Runtime.CompilerServices;
using System.Transactions;

namespace fritids_prosjekter;

class Program
{
    static void Main(string[] args)
    {
        double currentAssignments = 3;
        string elevNavn;
        string grade;

        elevNavn = "Lars";
        int larsTest1 = 90;
        int larsTest2 = 77;
        int larsTest3 = 88;
        double average = (larsTest1 + larsTest2 + larsTest3) / currentAssignments;

        if (average >= 90)
        {
            grade = "A";
            Console.WriteLine("Student\t\tPoeng\t\tKarakter");
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average <= 90)
        {
            grade = "B";
            Console.WriteLine("Student\t\tPoeng\t\tKarakter");
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }





    }
}
