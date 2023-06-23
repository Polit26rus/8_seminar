int Prompt(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray2d()
{
    int m = Prompt("Введите значение строк: ");
    int n = Prompt("Введите значение столбцов: ");
    int[,] array = new int[m, n];
    for(int i = 0;i < m;i++){
        for(int j = 0;j < n;j++){
            array[i, j] = new Random().Next(-100, 101);
        }

    }

    return array;
}
void PrintArray2d(int [,] array2d)
{
    for(int i = 0;i < array2d.GetLength(0);i++){
        for(int j = 0;j < array2d.GetLength(1);j++){
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = GetArray2d();
PrintArray2d(array2d);
Console.WriteLine();


// 54
// void ArrayChange(int [,] array){

//     int[] temp;
//     for(int i = 0;i < array.GetLength(0);i++){    
//         temp = new int[array.GetLength(1)];
//         for(int j = 0;j < array.GetLength(1);j++){
//             temp[j] = array[i,j];
//         }
//         Array.Sort(temp);
//         Array.Reverse(temp);
//         for(int k = 0;k < array.GetLength(1);k++){
//            array[i,k] = temp[k];
//         }
//     }
// }
// 
// ArrayChange(array2d);
// PrintArray2d(array2d);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int RowWithLowestElSum(int [,] array){
//     int [] sumArr = new int[array.GetLength(0)];
//     int sum;
//     int lowestSum;
//     for(int i = 0;i < array.GetLength(0);i++){
//         sum = 0;
//         for(int j = 0;j < array.GetLength(1);j++){
//             sum += array[i,j];
//         }
//         sumArr[i] = sum;
//     }
//     int lowestSumInd = 0;
//     lowestSum = sumArr[0];
//     for(int k = 1;k < sumArr.Length;k++){
//         if(lowestSum > sumArr[k]){
//             lowestSum = sumArr[k];
//             lowestSumInd = k;
//         }
//     }
//     return lowestSumInd;
    
// }
// Console.WriteLine($"{RowWithLowestElSum(array2d) + 1} строка");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

