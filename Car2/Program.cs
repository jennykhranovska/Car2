namespace Car2
{
    internal class Program
    {
        static void Main(string[] args) 

        {
            Car2 Volvo = new Car2("Volvo", "Red", 300, 590, CarType.Electric); 
           

            Car2 Ferrari  = new Car2("Ferarri", "Grean", 350, 600, CarType.Hybrid);

        

            Volvo.ShowInfo();
            Volvo.Drive();
            Volvo.Honk();
            Volvo.Fuel();

        }


    }
}
