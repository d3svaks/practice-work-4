using System.Text;

Console.OutputEncoding = Encoding.Unicode;
int playerHealth = 100, maxHealth = 100, gold = 0,
posX = 1, posY = 1;

//вывод игрового поля
Console.WriteLine("###");
Console.WriteLine("###");
Console.WriteLine("###");

//вывод персонажа
Console.ForegroundColor = ConsoleColor.Green;
Console.SetCursorPosition(posX, posY);
Console.Write("H");
Console.ResetColor();
Console.SetCursorPosition(0, 3);

//вывод строки состояния
Console.WriteLine($"💕[{playerHealth}/{maxHealth}] {gold,3}💰");

//считывание данных
int enemyDamage;
Console.Write(" Введите урон противника: ");

// ПРОВЕРКА НА ЧИСЛО: если ввели слово, урон будет 0 и выведется ошибка
if (!int.TryParse(Console.ReadLine(), out enemyDamage))
{
    Console.WriteLine("Ошибка: введено не число!");
    enemyDamage = 0;
}

// ПРОВЕРКА НА МИНУС: урон не может лечить
if (enemyDamage < 0)
{
    enemyDamage = 0;
}

playerHealth -= enemyDamage;
if (playerHealth < 0) playerHealth = 0;
Console.SetCursorPosition(0, 3);
Console.WriteLine($"💕[{playerHealth}/{maxHealth}] {gold,3}💰");

//передвижение игрока
Console.SetCursorPosition(0, 5);
Console.Write(" Двинуться: ");
var key = Console.ReadKey();
if (key.Key == ConsoleKey.W)
{
    //вверх
    Console.SetCursorPosition(posX, posY);
    Console.Write("#");
    posY -= 1;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(posX, posY);
    Console.Write("H");
    Console.ResetColor();
    Console.SetCursorPosition(0, 5);
}
else if (key.Key == ConsoleKey.A)
{
    //влево
    Console.SetCursorPosition(posX, posY);
    Console.Write("#");
    posX -= 1;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(posX, posY);
    Console.Write("H");
    Console.ResetColor();
    Console.SetCursorPosition(0, 5);
}
else if (key.Key == ConsoleKey.D)
{
    //вправо
    Console.SetCursorPosition(posX, posY);
    Console.Write("#");
    posX += 1;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(posX, posY);
    Console.Write("H");
    Console.ResetColor();
    Console.SetCursorPosition(0, 5);
}
else if (key.Key == ConsoleKey.S)
{
    //вниз
    Console.SetCursorPosition(posX, posY);
    Console.Write("#");
    posY += 1;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(posX, posY);
    Console.Write("H");
    Console.ResetColor();
    Console.SetCursorPosition(0, 5);
}
else Console.WriteLine("не ходьба");