/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите М чисел");
string str = Console.ReadLine();
var arrStr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] arr = Array.ConvertAll(arrStr, Convert.ToInt32);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"количествр чисел больше 0: {count}");
