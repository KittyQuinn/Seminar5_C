// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[]array = {1,2,3,4,5};

int lastIndex = array.Length - 1; // 5-1=4

int[]resultArray = new int [array.Length/2+array.Length%2];


for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i]=array[i]*array[lastIndex-i];

if (i == lastIndex - i)
    {
        resultArray[i] = array[i];
    }
}
Console.WriteLine(String.Join(",", resultArray));