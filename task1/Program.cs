// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size=8;
            int[] array = new int[size];
            for(int i=0;i<array.Length;i++){
                array[i]= new Random().Next(100,1000);
            }
            for(int i=0;i<array.Length;i++){
                Console.Write(Convert.ToString(array[i]) + " ");
            }
            Console.WriteLine();
            int kolvo=Kolvo_array(array);
            Console.WriteLine($"Количество четных чисел - {kolvo}");
        }

        static int Kolvo_array(int[] arr){
            int kol=0;
            for(int i=0;i<arr.Length;i++){
                if(arr[i]%2==0){
                    kol++;
                }
            }
            return kol;
        }
    }
}
