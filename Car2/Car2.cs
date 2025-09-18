using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class Car2
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;
        public int HorsePower;
        public CarType CarType;





        public void ShowInfo()
        {
            Console.WriteLine($"Carinfo: {Brand}, {Color}, {MaxSpeed}");
        }
        public void Drive()
        {
            Console.WriteLine($"The {Brand} is driving at MaxSpeed {MaxSpeed}");
      
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk");
                
        }
        public void Fuel()

        {
            Console.WriteLine($"Car is of type: {CarType}");
            switch (CarType)
            {
                case CarType.Electric:
                    Console.WriteLine("electric fuel");
                    break;

                case CarType.Gas:
                    Console.WriteLine("gas fuel");
                    break;

                case CarType.Disel:
                    Console.WriteLine("disel fuel");
                    break;

                case CarType.Hybrid:
                    Console.WriteLine("hybrid fuel");
                    break;

            }

        }
                 
    }

}
