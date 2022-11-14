// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[]array = {1,2,3,4,5};

int len = array.Length%2;
int newIndex = 0;
int newNum = 0;

int index = array.Length -1;
int[]result = new int [array.Length/2+array.Length%2];

if (len>0)
{newIndex = array.Length/2+1;}

for (int i = 0; i < result.Length; i++)
{
    result[i]=array[i]*array[index-i];
    Console.WriteLine(result[i]);
    if (newIndex==i)
    {
        newNum = array[i];
        Console.WriteLine(newNum);
    }
}