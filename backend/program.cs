Console.WriteLine("Hello, World!");
Console.WriteLine("Меня зовут Федотова В.С.");
Console.WriteLine(DateTime.Now);
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine().ToString();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine("Хотите продолжить? (y/n)");
string choice = Console.ReadLine().ToString();
if (choice == "yes")
    Console.WriteLine("Отлично, давайте продолжим.");
else if (choice == "no")
    Console.WriteLine("Завершение работы...");
else
    Console.WriteLine("Некорректный ввод.");