//namespace Exeption
//{
//    internal class Program
//    {
       
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("\n=== Калькулятор систем счисления ===");
//                Console.WriteLine("1 - Из 10 в 2");
//                Console.WriteLine("2 - Из 2 в 10");
//                Console.WriteLine("3 - Из 10 в 16");
//                Console.WriteLine("4 - Из 16 в 10");
//                Console.WriteLine("0 - Выход");
//                Console.Write("Выберите пункт: ");

//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        ConvertFromDecimal(2);
//                        break;
//                    case "2":
//                        ConvertToDecimal(2);
//                        break;
//                    case "3":
//                        ConvertFromDecimal(16);
//                        break;
//                    case "4":
//                        ConvertToDecimal(16);
//                        break;
//                    case "0":
//                        return;
//                    default:
//                        Console.WriteLine("Неверный выбор!");
//                        break;
//                }
//            }
//        }

//        static void ConvertFromDecimal(int targetBase)
//        {
//            Console.Write("Введите число в десятичной системе: ");
//            string input = Console.ReadLine();

//            if (!int.TryParse(input, out int number))
//            {
//                Console.WriteLine("Ошибка: некорректный ввод или выход за диапазон int.");
//                return;
//            }

//            string result = Convert.ToString(number, targetBase);
//            Console.WriteLine($"Результат: {result}");
//        }

//        static void ConvertToDecimal(int sourceBase)
//        {
//            Console.Write($"Введите число в системе с основанием {sourceBase}: ");
//            string input = Console.ReadLine();

//            try
//            {
//                int result = Convert.ToInt32(input, sourceBase);
//                Console.WriteLine($"Результат: {result}");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Ошибка: неправильный формат числа.");
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Ошибка: число выходит за пределы типа int.");
//            }


//        }
//    }
//}
