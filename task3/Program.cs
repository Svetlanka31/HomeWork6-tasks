// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

const  int ARRAY_SIZE = 8;
const int LEFT_RANGE =-10;
const int RIGTH_RANGE = 10;

int [] FillArray(int size,  int leftRange,int rigthRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange,rigthRange +1);
    }
    return arr;
}
int [] CopyArr(int [] arr2,int size)
{
    int[]arrA = new int[size];
    int[]arrB = new int[size];
    for(int i =0; i <arr2.Length; i++)
    {
        arrB[i] = arrA[i]; 
    }
    return arr2;
}
int [] array = FillArray(ARRAY_SIZE,LEFT_RANGE,RIGTH_RANGE);
Console.WriteLine('[' + string.Join(", ", array) +']');
int []array2 = CopyArr(array,ARRAY_SIZE);
Console.WriteLine('[' + string.Join(", ", array) +']');

