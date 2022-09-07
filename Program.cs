//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size){                     //функция создания массива из трехзначных чисел
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void ShowArray(int[] array){                           //функция вывода массива
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int EvenNum(int[] array){                              //определение четных чисел в массиве и подсчет их количества
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        int div = array[i]%2;
        if(div == 0 ) count++;
    }
    return count;
}

Console.WriteLine("Input size: ");                       //ввод размера массива
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);

int even = EvenNum(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве {even}"); //вывод данных



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max){        //функция создания массива
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array){                       //функция вывода массива
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int SumEl(int[] array){                           //Находим элементы на нечетных позициях массива и суммируем значения
    int sum = 0;
    for(int i = 0; i<array.Length; i++){
        if(i%2 != 0){
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,min,max);
ShowArray(array);

int posSum = SumEl(array);

Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {posSum}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int Difference(int[] array){
    int ind = 0;
    int max = array[ind];                     //Назначаем первый элемент массива максимальным и минимальным. 
    int min = array[ind];                     //Сравниваем значения элементов массива и сохраняем новые значения макс и мин
    for(int i = 0; i<array.Length; i++){
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
    int diff = max - min;                     //Находим разницу
    return diff;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine();

int dif = Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {dif}");