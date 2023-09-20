double nomer;
double a;
double b;
double c;
do
{
    Console.WriteLine("Добро пожаловать в калькулятор!:)");
    Console.WriteLine("Выберите дйствие");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Выйти из программы");

    nomer = Convert.ToInt32(Console.ReadLine());
    switch (nomer)
    {
        case 1:
            Console.WriteLine("Первое значение");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Второе значение");
            double.TryParse(Console.ReadLine(), out b);
            c = a + b;
            Console.WriteLine("Сумма 2 значений равна: " + c);
            break;
        case 2:
            Console.WriteLine("Первое значение");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Второе значение");
            double.TryParse(Console.ReadLine(), out b);
            c = a - b;
            Console.WriteLine("Разность 2 значений равна: " + c);
            break;
        case 3:
            Console.WriteLine("Первое значение");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Второе значение");
            double.TryParse(Console.ReadLine(), out b);
            c = a * b;
            Console.WriteLine("Произведение 2 значений равна: " + c);
            break;
        case 4:
            Console.WriteLine("Первое значение");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Второе значение");
            double.TryParse(Console.ReadLine(), out b);
            c = a / b;
            Console.WriteLine("Частное 2 значений равна: " + c);
            break;
        case 5:
            Console.WriteLine("Первое значение");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Второе значение");
            double.TryParse(Console.ReadLine(), out b);
            c = Math.Pow(a, b);
            Console.WriteLine("Степень первого числа равна  " + c);
            break;
        case 6:
            Console.WriteLine("Введите значение");
            double.TryParse(Console.ReadLine(), out a);
            if (a > 0)
            {
                c = Math.Sqrt(a);
                Console.WriteLine("Квадратный корень данного числа равен: " + c);
            }
            while (a <= 0)
            {
                Console.WriteLine("Я не могу это вычислить :(");
            }
            break;
        case 7:
            Console.WriteLine("Введите значение");
            double.TryParse(Console.ReadLine(), out a);
            c = a / 100;
            Console.WriteLine("1% от данного числа равен " + c);
            break;
        case 8:
            Console.WriteLine("Досвидание!");
            break;
    }
} while (nomer! < 8);