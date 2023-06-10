using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            INodeElement p1 = new Person ("Jaun", 21, 1);
            INodeElement p2 = new Person ("Charly", 24, 2);
            INodeElement p3 = new Person ("Ricky", 31, 3);
            INodeElement p4 = new Person ("Fer", 28, 4);
            INodeElement p5 = new Person ("Mike", 29, 5);
            INodeElement p6 = new Person ("Carlos", 21, 6);
            INodeElement p7 = new Person ("Ricardo", 35, 7);
            INodeElement p8 = new Person ("Homero", 36, 8);

            Node n1 = new Node(1, p1);
            Node n2 = new Node(2, p2);
            Node n3 = new Node(3, p3);
            Node n4 = new Node(4, p4);
            Node n5 = new Node(5, p5);
            Node n6 = new Node(6, p6);
            Node n7 = new Node(7, p7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            
            IComputable calculatePersonAge = new CalculatePersonAge(n1);
            Calculator calculator1 = new Calculator(calculatePersonAge);
            int PersonFamilyAge = calculator1.Calc();
            Console.WriteLine($"Ages sum of Person's family: {PersonFamilyAge}");

            IComputable calculateOldestFamilyMember = new CalculateOldestFamilyMember(n1);
            Calculator calculator2 = new Calculator(calculateOldestFamilyMember);
            int OldestFamilyMember = calculator2.Calc();
            Console.WriteLine($"Oldest family member: {OldestFamilyMember}");

            IComputable CalculateLongestPersoName = new CalcLongestPersName(n1);
            Calculator calculator3 = new Calculator(CalculateLongestPersoName);
            int LongestPersoNameId = calculator3.Calc();
            Console.WriteLine($"Id of the person with the longest name: {LongestPersoNameId}");
        }
    }
}
