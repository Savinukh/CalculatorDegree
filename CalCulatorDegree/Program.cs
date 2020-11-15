using System;

namespace CalCulatorDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodCelsiusToFahrenheit();
        }
        static void MethodCelsiusToFahrenheit()
        {
            Console.Write("Введите температуру по шкале Цельсия:\t");
            int temperature = int.Parse(Console.ReadLine());
            double result = 0;
            result = temperature * 1.8 + 32;
            Console.WriteLine("{0}°С перевод в Френгейт: {1}°F", temperature, result);
            Console.ReadKey();
        }
    }
}
