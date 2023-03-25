//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите числа: ");
string[] array = Console.ReadLine().Split(" ");
Console.Write($"[{string.Join (", ", array)}] -> {CountPos(array)}");

int CountPos(string[] array){
    int count = 0;
        foreach (string el in array){
            count += int.Parse(el) > 0 ? 1 : 0;}
    return count;}


