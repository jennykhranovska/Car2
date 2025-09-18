namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car2 ferrari = new Car2(); //   deklarere en ferrari
            ferrari.Color = "Red";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 380;
            ferrari.HorsePower = 500;
            ferrari.CarType = CarType.Gas;

            Car2 volvo = new Car2();
            volvo.Color = "Green";
            volvo.Brand = " Volvo";
            volvo.MaxSpeed = 350;
            volvo.HorsePower = 450;
            volvo.CarType = CarType.Disel;


            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();


            volvo.ShowInfo();
            volvo.Fuel();
            volvo.Honk();
            volvo.Drive();
        }


    }
}
