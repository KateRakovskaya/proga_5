//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int InputArr(int[] arr, int n){
//     Random rnd = new Random();
//     for(int i = 0; i < n; i++) {
//         arr[i] = rnd.Next(100, 999);
//     }
//     return 0;
// }
// int PrintArr(int[] arr, int n){
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < n; i++){
//         Console.Write($"{arr[i]} ");
//     }
//     return 0;
// }
// int Count(int[] arr, int n){
//     int count = 0;
//     for (int i = 0; i < n; i++){
//         if(arr[i]%2 == 0) count++;
//     }
//     Console.WriteLine($"\nВ массиве четных чисел: {count} ");
//     return 0;
// }
// int n = 5;
// int[] arr = new int[n];
// InputArr(arr, n);
// PrintArr(arr, n);
// Count(arr, n);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int InputArr(int[] arr, int n){
//     Random rnd = new Random();
//     for(int i = 0; i < n; i++) {
//         arr[i] = rnd.Next(0, 1000);
//     }
//     return 0;
// }
// int PrintArr(int[] arr, int n){
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < n; i++){
//         Console.Write($"{arr[i]} ");
//     }
//     return 0;
// }
// int Count(int[] arr, int n){
//     int sum = 0;
//     for (int i = 1; i < n; i += 2){
//         sum += arr[i];
//     }
//     Console.WriteLine($"\nСумма чисел на нечетных позициях: {sum} ");
//     return 0;
// }
// int n = 5;
// int[] arr = new int[n];
// InputArr(arr, n);
// PrintArr(arr, n);
// Count(arr, n);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int InputArr(double[] arr, int n){
    Random rnd = new Random();
    for(int i = 0; i < n; i++) {
        arr[i] = rnd.Next(0, 100);
    }
    return 0;
}
int PrintArr(double[] arr, int n){
    Console.WriteLine("Массив: ");
    for (int i = 0; i < n; i++){
        Console.Write($"{arr[i]} ");
    }
    return 0;
}
int Count(double[] arr, int n){
    double max = -1;
    double min = 10000;
    for (int i = 0; i < n; i++){
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"\nРазница между максимальным и минимальным: {max-min} ");
    return 0;
}
int n = 5;
double[] arr = new double[n];
InputArr(arr, n);
PrintArr(arr, n);
Count(arr, n);