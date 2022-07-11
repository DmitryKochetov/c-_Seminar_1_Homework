//Задача 6: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).


Console.WriteLine("Введите целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

//Проверяем, делится ли на 2 без остатка и выводим ответ в консоль
if (num1 == 0)
{
    Console.WriteLine("Введен 0");
}
else if (num1 % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
