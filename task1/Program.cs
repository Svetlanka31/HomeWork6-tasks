// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void EnterNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.WriteLine($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int FindPositivNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 )
    { 
        count ++;
    }
  }
  return count;
}

EnterNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {FindPositivNumbers(array)} ");

