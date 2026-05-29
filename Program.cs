namespace Class_05_29_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 =new Person();
            //Console.WriteLine(p1.GetName());
            //Console.WriteLine(p1.GetName("德明"));
            Console.WriteLine(Person.GetName());
            Console.WriteLine(Person.GetName("德明"));
            Console.WriteLine(Person.GetName("德明", "資管"));
            Console.WriteLine(Person.GetNumber(5));
            Console.WriteLine(Person.GetNumber(5));
        }
    }
}
