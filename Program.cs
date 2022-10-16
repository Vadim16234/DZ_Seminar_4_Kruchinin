// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// РЕШЕНИЕ

// Console.WriteLine("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine()!);
// int Array(int numA, int numB){
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//     result = result * numA;
//     }
//     return result;
// }
// int array = Array(numA, numB);
// Console.WriteLine($"Число {numA} в натуральной степени {numB} равно {array}");







// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// РЕШЕНИЕ

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма цифр в {num} равна {SumDigitsNumber(num)}");


// int SumDigitsNumber(int number){
//     int numberLengt = Convert.ToString(number).Length;
//     int sum = 0;
//     for(int i = 1; i <= numberLengt; i++){
//         sum = sum + num % 10; 
//         num /= 10; 
//     }
//     return sum;
//}
   

   



// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// GetArray(array.Length);
// Console.WriteLine($"[{String.Join(", ", array)}] ");


// void GetArray (int size){
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,50);
//     }
// }
