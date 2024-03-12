namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Building buiding = new Building("улица Клубничная", 34, 15, 100);
            MultiBuilding multiBuilding = new MultiBuilding("улица Морковная", 25, 12, 110,10);
            Console.WriteLine(buiding.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
