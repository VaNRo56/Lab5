namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airbus300 = new Airplane();
            Console.WriteLine(airbus300.CalculateTravelTime(2000, 650));
            Console.WriteLine(airbus300.CalculateCost(2000, 650));
            

            CarBus sprinter2500 = new CarBus();
            Console.WriteLine(sprinter2500.CalculateTravelTime(2000, 120));
            Console.WriteLine(sprinter2500.CalculateCost(2000, 120));
            

            Train deutcheBahn = new Train();
            Console.WriteLine(deutcheBahn.CalculateTravelTime(2150, 280));
            Console.WriteLine(deutcheBahn.CalculateCost(2150, 280));
        

            FlyingDevice bayraktarV2 = new FlyingDevice();
            Console.WriteLine(bayraktarV2.CalculateTravelTime(2000, 300));
            Console.WriteLine(bayraktarV2.CalculateCost(2000, 300));
  

            Helicopter apache = new Helicopter();
            Console.WriteLine(apache.CalculateTravelTime(2000, 500));
            Console.WriteLine(apache.CalculateCost(2000, 500));
        }
    }
}