// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size=8;
            double[] array = new double[size];
            for(int i=0;i<array.Length;i++){
                array[i]= new Random().Next(0,100)  + new Random().NextDouble();
            }
            for(int i=0;i<array.Length;i++){
                Console.Write(Convert.ToString(array[i]) + " ");
            }
            Console.WriteLine();
            double min = Min_array(array);
            double max = Max_array(array);
            Console.WriteLine($"Разница между максимальным и минимальным значениями равна {max-min}");
        }

        static double Min_array(double[] arr){
            double min_arr = arr[0];
            for(int i=0;i<arr.Length;i++){
                if(min_arr>arr[i]){
                    min_arr=arr[i];
                }
            }
            return min_arr;
        }
        
        static double Max_array(double[] arr){
            double max_arr = arr[0];
            for(int i=0;i<arr.Length;i++){
                if(max_arr<arr[i]){
                    max_arr=arr[i];
                }
            }
            return max_arr;
        }
    }
}
