// вар 22
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

public struct mus
{

    public string name;
    public double time;
    public mus(string a, double b)
    {
        name = a;
        time = b;
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Random random = new Random();
            int i, j;
            while (true)
            {
                Clear();
                Console.WriteLine("Задание 1");
                Console.WriteLine("Задание 2");
                Console.WriteLine("Задание 3");
                Console.WriteLine("Выход");
                Console.WriteLine("Выберите:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Clear();
                        Console.WriteLine("Задача 1:");
                        Console.WriteLine("Введите массив из 15 элементов");
                        int[] mass = new int[15];
                        int sch = 0;
                        for (i = 0; i < 15; i++)
                        {
                            Console.Write("A[{0}] = ", i);
                            mass[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        for (i = 0; i < 15; i++)
                        {
                            if (mass[i] < 0)
                            {
                                sch++;
                            }
                        }
                        Console.WriteLine("Количество отрицательных элементов: {0}", sch);
                        Console.ReadKey();
                        break;
                    case 2:
                        Clear();
                        Console.WriteLine("Задание 2");
                        decimal[,] matrix = new decimal[8, 3];
                        for (i = 0; i < 8; i++)
                        {
                            for (j = 0; j < 3; j++)
                            {
                                matrix[i, j] = Math.Round((random.Next(3, 99) / 3.0m), 0);
                            }
                        }
                        for (i = 0; i < 8; i++)
                        {
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(matrix[i, j] + "\t");
                            }
                            Console.WriteLine("\n");
                        }
                        int[] newm = new int[8];
                        for (i = 0; i < 8; i++)
                        {
                            int a = 0;
                            for (int k = 0; k < 3; k++)
                                a += Convert.ToInt32(matrix[i, k]);
                            newm[i] = a / 3;
                        }
                        for (i = 0; i < 8; i++)
                        {
                            Console.WriteLine("A[{0}] = {1}", i, newm[i]);
                        }

                        Console.ReadKey();
                        break;
                    case 3:
                        Clear();
                        Console.WriteLine("Задание 3");
                        List<mus> music = new List<mus>();
                        mus newel;
                        var song1 = new mus("йупи йо", 2.34);
                        music.Add(song1);
                        song1 = new mus("Вставай донбасс", 3.56);
                        music.Add(song1);
                        song1 = new mus("За деньги да", 15);
                        music.Add(song1);
                        song1 = new mus("Отключаю телефон", 2.23);
                        music.Add(song1);
                        song1 = new mus("Help!", 4.2);
                        music.Add(song1);

                        foreach (var item in music)
                        {
                            if (item.time > 3)
                                Console.WriteLine("Имя: {0}, Длительность: {1} минут", item.name, item.time);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Clear();
                        Console.WriteLine("Введите число от 1 до 3");
                        break;
                }
            }

        }
    }
}