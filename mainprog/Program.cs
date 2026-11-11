using lab6_task1;
using lab6_task2;
using lab6_task3;
using help_console_input_tools;
using buckets_with_apples;
using humans;

using System.Collections;
using System.Xml.Linq;

namespace mainprog;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            string? choosed_task;

            Console.Clear();
            Console.WriteLine("/ Лабораторная работа №6, вариант-1. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251\\");
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            Console.WriteLine("| 1) Создать однородную коллекцию List<T>                      | 4) *Windows Forms       |");
            Console.WriteLine("| 2) Создать разнородную коллекцию List<T> по теме \"человек\"   | 5) *Windows Forms       |");
            Console.WriteLine("| 3) Ввод-вывод хэш-таблицы по теме \"человек\"                  | 6) *Windows Forms       |");
            Console.WriteLine("+----------------------------------------------------------------------------------------/");
            Console.Write("\\ Выберите цифру задачи и нажмите Enter: ");

            choosed_task = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosed_task))
                continue;

            switch (choosed_task)
            {
                case "1":
                    task1.Run();
                    break;
                case "2":
                    task2.Run();
                    break;
                case "3":
                    task3.Run();
                    break;
                case "4":
                    Application.Run(new FormOf1());
                    break;
                case "5":
                    Application.Run(new FormOf2());
                    break;
                case "6":
                    Application.Run(new FormOf3());
                    break;
            }
        }
    }
}