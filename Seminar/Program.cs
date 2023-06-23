// 53

// int Prompt(string text){
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             array[i, j] = new Random().Next(-100, 101);
//         }

//     }

//     return array;
// }
// void PrintArray2d(int [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] RowChange(int [,] array)
// {   
//     int[] temporary = new int[array.GetLength(0)];
//     for(int i = 0;i < array.GetLength(0);i++){
//         for(int j = 0;j < array.GetLength(1);j++){
//         if(i == 0){
//                 temporary[j] = array[i,j];
//                 array[i,j] = array[array.GetLength(0) - 1,j];
//             }
//         else if(i == array.GetLength(0) - 1){
//             array[i,j] = temporary[j];
//         }
//         }
//     }
//     return array;
// }

// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// array2d = RowChange(array2d);
// Console.WriteLine();
// PrintArray2d(array2d);

// 55

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }

//     }

//     return array;
// }
// void PrintArray2d(int[,] array2d)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void RowsOnColumns(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         int[,] newArray = new int[array.GetLength(0),array.GetLength(1)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0;j < array.GetLength(1);j++){
//                 newArray[i,j] = array[j,i];
//             }

//         }
//         PrintArray2d(newArray);
//     }
//     else Console.WriteLine("Невозможно");

// }

// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// Console.WriteLine();
// RowsOnColumns(array2d);


// 57

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int m = Prompt("Input m");
// int n = Prompt("Intput n");

// int[,] GetArray2s()
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }

//     return array;
// }

// void PrintArray2d(int[,] array2d)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] NewArray(int[,] array2d)
// {

//     int[] newArray = new int[array2d.GetLength(0) * array2d.GetLength(1)];
//     int ind = 0;
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             newArray[ind] = array2d[i, j];
//             ind++;
//         }
//     }

//     return newArray;
// }

// void Test(int[] array)
// {
//     int el = array[0];
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (el == array[i])
//         {
//             count++;
            
//         }
//         else {
            
//             Console.WriteLine($"{el} встречается {count} раз, ");
//             count = 1;
//             el = array[i];
//         }
        
//     }

// Console.WriteLine($"{el} встречается {count} раз, ");
// }


// int[,] array2d = GetArray2s();
// PrintArray2d(array2d);
// Console.WriteLine();
// int[] array2dtransform = NewArray(array2d);
// Console.WriteLine(String.Join(",", array2dtransform));
// Array.Sort(array2dtransform);
// Console.WriteLine(String.Join(",", array2dtransform));
// Console.WriteLine();
// Test(array2dtransform);