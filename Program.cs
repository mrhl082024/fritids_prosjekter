using System.Runtime.CompilerServices;
using System.Transactions;

namespace fritids_prosjekter;

class Student
{
    public int currentAssignments;
    string elevName;
    string grade;
    double average;
    public Student(string name)
    {
        currentAssignments = 0;
        elevName = name;
        grade = "";
        average = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int currentAssignments = 3;
        string elevNavn;
        string grade;
        double average;

        var lars = new Student("Lars");

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
        else if (average <= 90)
        {
            grade = "B";
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
            Console.WriteLine($"{elevNavn}\t\t{(int)average}\t\t{grade}");
        }
        else if (average <= 90)
        {
            grade = "B";
            Console.WriteLine($"{elevNavn}\t\t{average}\t\t{grade}");
        }





    }
}
