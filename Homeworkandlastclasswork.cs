using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex112();
            //ex212();
            int colvo=0;
            double sum = 0;
            int last=0;
            double[] array = new double[10] { 2.3, 0, -5.1, 3.5, -2.3,1.1, -12.7, 0, 1.8, -4.6 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("Между нулевыми элементами находятся: ");
            colvo=Array.IndexOf(array, 0);
            last=Array.LastIndexOf(array,0);
            for (int i = 0; i < array.Length; i++)
            {
                if (i > colvo && i < last)
                {
                    sum+= array[i];
                    Console.WriteLine(array[i]);
                    
                }
            }
            Console.WriteLine("Сумма этих элементов:"+sum);
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.ReadKey();
        }

        private static void ex212()
        {
            int colvo = 0;
            double sum = 0;
            double[] array = new double[5] { 2.3, 4.5, 5.1, 3.5, 2.3 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("До максимального элемента находятся: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                {
                    sum = array[i];
                }
            }
            double proizv = 1;
            int c = Array.IndexOf(array, sum);
            for (int i = 0; i < array.Length; i++)
            {
                if (i < c)
                {
                    if (array[i] > 0)
                    {
                        proizv = proizv * array[i];
                        Console.WriteLine(array[i]);
                    }

                }
            }
            Console.WriteLine("Их произведение: " + proizv);
            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array);
                Console.Write(array[i] + "\t");
            }
            Console.ReadKey();
        }

        private static void ex112()
        {
            int colvo = 0;
            double sum = 0;
            double arifm = 0;
            double[] array = new double[10] { 2.3, 4.5, -5.1, 3.5, -2.3, 1.1, -12.7, 2.4, 1.8, -4.6 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("После минимального элемента находятся следующие отрицательные числа:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                {
                    sum = array[i];

                }


            }
            double proizv = 1;
            int c = Array.IndexOf(array, sum);
            for (int i = 0; i < array.Length; i++)
            {
                if (i > c)
                {
                    if (array[i] < 0)
                    {
                        proizv = proizv * array[i];
                        Console.WriteLine(array[i]);
                    }

                }
            }
            Console.WriteLine("Их произведение: " + proizv);
            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array);
                Array.Reverse(array);
                Console.Write(array[i] + "\t");
            }
            Console.ReadKey();
        }

        private static void ex11()
        {
            int n = 6;
            int colvo = 0;
            int sum = 0;
            float arifm = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите числа в массиве");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine(array[i]);
            }
            arifm = sum / array.Length;
            Console.WriteLine("Числа, которые меньше ср. арифметического:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < arifm)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        private static void ex10()
        {
            int n = 6;
            int colvo = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите числа в массиве");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Введите число которое хотите найти");
            int x = Convert.ToInt32(Console.ReadLine());
            foreach (char item in array)
            {
                if (x == item)
                {
                    colvo += 1;
                }

            }
            if (colvo == 0)
            {
                Console.WriteLine("В массиве нет такого числа");
            }
            else
            {
                Console.WriteLine("В массиве есть: " + colvo + " числа " + x);
            }
            Console.ReadKey();
        }

        private static void ex9()
        {
            string c = string.Empty;
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {

                    Console.Write(table[i, j] + "\t");


                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            Console.WriteLine();
            for (int j = 0; j < col; j++)
            {
                c = table[row - 1, j];
                table[row - 1, j] = table[0, j];
                table[0, j] = c;


            }
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {

                    Console.Write(table[i, j] + "\t");


                }
                Console.WriteLine();
            }
        }


        private static void ex8()
        {
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    if (Convert.ToInt32(table[i, j]) < 0)
                    {
                        table[i, j] = "0";
                    }
                    else if (Convert.ToInt32(table[i, j]) == 0)
                    {
                        table[i, j] = "25";
                    }
                    Console.Write(table[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }

        private static void ex7()
        {
            float sum = 0;
            int[] array = new int[10];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифмитическое =");
            Console.WriteLine(sum / 10);
        }

        private static void ex6()
        {
            int sumotr = 0;
            int sumpol = 0;
            int colvo = 0;
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    if (Convert.ToInt32(table[i, j]) < 1)
                    {
                        sumotr += Convert.ToInt32(table[i, j]);
                    }
                    if (Convert.ToInt32(table[i, j]) >= 1)
                    {
                        sumpol += Convert.ToInt32(table[i, j]);
                    }
                    if (Convert.ToInt32(table[i, j]) == 0)
                    {
                        colvo++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма положительных элементов: " + sumpol);
            Console.WriteLine("Сумма отрицательных элементов: " + sumotr);
            Console.WriteLine("Кол-во нулевых элементов: " + colvo);
        }

        private static void ex5()
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите числа в массиве");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Массив до реверса");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }
            Array.Reverse(array);
            Console.WriteLine("Массив после реверса");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex4()
        {
            int sum = 0;
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                    {
                        sum += Convert.ToInt32(table[i, j]) * Convert.ToInt32(table[i, j]);
                    }

                }


            }
            Console.WriteLine("--------------------------");
            Console.WriteLine(sum);
            Console.WriteLine();
        }

        private static void ex3()
        {
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    Console.Write(table[j, i] + "\t");

                }
                Console.WriteLine();

            }
        }

        private static void ex2()
        {
            int[] array = new int[41];
            int number = 9;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                number += 1;
                array[i] = number;

                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }

        private static void ex1()
        {
            int index = 0;
            int lengh = 0;
            string[] lines = File.ReadAllLines("data.csv");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            string[,] table = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = values[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    Console.Write(table[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------");
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {

                    index += Convert.ToInt32(table[i, j]);
                    lengh = row;

                }
                Console.Write((index / lengh) + "\t");
                index = 0;

            }
        }
    }
}

