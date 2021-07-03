using System;
using System.Linq;

namespace MotoCompany
{
   internal class Motorcycle
    {
        public string moto_Brand;
        public string moto_Model;
        internal string vin_Number;
        public int moto_Odometer;
        public int moto_Year;
        public class Engine
        {
            public string horsePower;
            public string cubicMeter;
            public string engineType;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            Motorcycle.Engine engine1 = new Motorcycle.Engine();
            Motorcycle moto1 = new Motorcycle();
            moto1.moto_Odometer = randomGenerator.Next(1, 100);
           
            Console.WriteLine("Введите марку мотоцикла:");
            moto1.moto_Brand = Console.ReadLine();
            Console.WriteLine("Введите модель мотоцикла:");
            moto1.moto_Model = Console.ReadLine();
            Console.WriteLine("Введите VIN-номер (Пример AA00-0000):");
            moto1.vin_Number = Console.ReadLine();
            Console.WriteLine("Введите количество лошадиных сил:");
            engine1.horsePower = Console.ReadLine();
            Console.WriteLine("Введите объем двигателя(cm3):");
            engine1.cubicMeter = Console.ReadLine();
            Console.WriteLine("Введите тип двигателя:");
            engine1.engineType = Console.ReadLine();
             Console.WriteLine("Производитель:" + moto1.moto_Brand + " " + "Модель:" + moto1.moto_Model + " " +
                "Пробег:"+moto1.moto_Odometer+"км"+" "+"VIN-номер:"+moto1.vin_Number+" "+"Мощность двигателя:"+engine1.horsePower + "hp"+
                " "+"Объем двигателя:" + engine1.cubicMeter+"cm3"+" "+"Тип двигателя:"+engine1.engineType);
        
            Motorcycle[] motorcycleArray = new Motorcycle[] { moto1};
         }
       
    }
}
