// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size=8;
            int[] array = new int[size];
            for(int i=0;i<array.Length;i++){
                array[i]= new Random().Next(0,100);
            }
            for(int i=0;i<array.Length;i++){
                Console.Write(Convert.ToString(array[i]) + " ");
            }
            Console.WriteLine();
            int symma = Sum_array(array);
            Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна {symma}");
        }

        static int Sum_array(int[] arr){
            int sym=0;
            for(int i=1;i<arr.Length;i+=2){
                sym+=arr[i];
            }
            return sym;
        }
    }
}
