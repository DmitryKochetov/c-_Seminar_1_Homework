//Задача 4: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

//В задании точно не указан способ, как программа принимает на вход числа
//Допустим, что их вводит пользователь, для наглядности
//также не указан тип данных. Примем, что тип данных integer

Console.WriteLine("Введите первое целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число:");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

//сравниваем числа и присваиваем переменной max значение наибольшего, выводим на экран

if (num2 > num1 && num2 > num3)
{
    max = num2;
}
if (num3 > num1 && num3 > num2)
{
    max = num3;
}

//вывод максимального числа в консоль
Console.WriteLine($"max = {max}");