// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

Console.Clear();



int[] array = new int [10];
Console.Write("Type a number you want to find ");
int find = int.Parse(Console.ReadLine());
bool tr = false;


for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-2, 10);

    Console.Write(array[i]+ " ");
        if (array[i] == find)

    {tr = true;}
}

if (tr == true)
{
    Console.WriteLine("Yes");
}

else 
{
    Console.WriteLine("No");
}





