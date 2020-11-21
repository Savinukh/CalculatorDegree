using System;

namespace CalCulatorDegree
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
            int i = 1;
            do
            {
                Console.WriteLine("Что вы хотите перевести (Цельсия в Фаренгейт) - 1, (Фаренгейт в Цельсия) - 0?");
                int answer = int.Parse(Console.ReadLine());
=======
            Console.WriteLine("Что вы хотите перевести (Цельсия в Фаренгейт) - 1, (Фаренгейт в Цельсия) - 0?");
            int answer = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
>>>>>>> main
                switch (answer)
                {
                    case 1:
                        MethodCelsiusToFahrenheit();
                        break;
                    case 0:
                        MethodFahrenheitToCelsius();
                        break;
                }
<<<<<<< HEAD
                Console.WriteLine("Хотите поробовать еще раз? да - 1, нет - 0");
                 i = int.Parse(Console.ReadLine());
                Console.Clear();
                
            }
            while (i != 0);
            Console.WriteLine("Программа закончена");
            Console.ReadKey();
=======
                Console.WriteLine("Хотите поробывать еще раз? да - 1, нет - 0");
                int answ = int.Parse(Console.ReadLine());
                Console.Clear();
                Main();


            }
            while (i == 1);
>>>>>>> main
            
                
        }
        static void MethodCelsiusToFahrenheit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.Write("Введите температуру по шкале Цельсия:\t");
            int temperature = int.Parse(Console.ReadLine());
            double result = temperature * 1.8 + 32;
            Console.WriteLine("{0}°С перевод в Фаренгейт: {1}°F", temperature, result);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
        }
        static void MethodFahrenheitToCelsius()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
<<<<<<< HEAD
=======
            Console.ReadKey();
>>>>>>> main
            Console.Write("Введите температуру по шкале Фаренгейта:\t");
            int temperature = int.Parse(Console.ReadLine());
            double result = (temperature - 32) / 1.8;
            Console.WriteLine("{0}°F перевод в Френгейт: {1}°С", temperature, result);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
        }
        
    }
}
