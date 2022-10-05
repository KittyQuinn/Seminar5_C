// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int size = 10;

int[] array = new int [size];

    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9, 9);
    
Console.Write(array[i]+ " ");
    }

Console.WriteLine();
int [] arr = new int [size];

for(int i = 0; i < array.Length; i++){
   arr[i] = array[i]* -1;

Console.Write(arr[i]+ " ");
}
Console.WriteLine();