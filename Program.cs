using System.Runtime.CompilerServices;
using System.Transactions;

namespace fritids_prosjekter;


class Program
{
    static void Main(string[] args)
    {
        int currentAssignments = 3;
        string elevNavn;
        string grade;
        double average;


        elevNavn = "Lars";
        int larsTest1 = 90;
        int larsTest2 = 77;
        int larsTest3 = 88;
        average = (larsTest1 + larsTest2 + larsTest3) / currentAssignments;
        Console.WriteLine("Student\t\tPoeng\t\tKarakter");


        if (average >= 90)
        {
            grade = "A";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 80)
        {
            grade = "B";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 70)
        {
            grade = "C";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 60)
        {
            grade = "D";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 50)
        {
            grade = "E";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average < 50)
        {
            grade = "F";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }

        elevNavn = "";
        grade = "";
        average = 0;


        elevNavn = "Geir";
        int geirTest1 = 99;
        int geirTest2 = 88;
        int geirTest3 = 96;
        average = (geirTest1 + geirTest2 + geirTest3) / currentAssignments;

        if (average >= 90)
        {
            grade = "A";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 80)
        {
            grade = "B";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 70)
        {
            grade = "C";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 60)
        {
            grade = "D";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average >= 50)
        {
            grade = "E";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }
        else if (average < 50)
        {
            grade = "F";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }





    }
}
