using CS_inheritance.Class;

namespace CS_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our builders: ");
            Builder builder = new Builder("John", 30, "1234567890");
            Console.WriteLine(builder);
            Console.WriteLine("Our sailors: ");
            Sailor sailor = new Sailor("Jack", 40, "0987654321");
            Console.WriteLine(sailor);
            Console.WriteLine("Our pilots: ");
            Pilot pilot = new Pilot("James", 50, "1357924680");
            Console.WriteLine(pilot);
        }
    }
}
