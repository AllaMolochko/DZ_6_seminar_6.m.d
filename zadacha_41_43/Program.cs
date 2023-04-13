//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//считать письмо с консоли
int Prompt(string message)
{
  System.Console.Write(message); //вывести сообщение
  string value = Console.ReadLine(); //считать с консоли строку  
  int result = Convert.ToInt32(value); //преобр строку в целое число
  return result; //возвращает результат
}
//ввести массив
int[] InputArray(int length)
{
  int[] array = new int [length];
  for (int i = 0; i  < array.Length; i++)
  {
    array[i] = Prompt($"введите {i + 1}) -й элемент");
  }
  return array;
}
void PrintArray (int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
     Console.WriteLine($"a[{i}]");
  }
}
int CountPositiveNumbers(int[] array)
{
int count = 0;
for (int i = 0; i  < array.Length; i++)
{
  if (array[i] > 0)
  {
    count++;
  }
}
return count;
}

int length = Prompt ("введите количество элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"количество чисел больше 0 - {CountPositiveNumbers(array)}");




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)