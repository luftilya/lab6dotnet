using BucketsWithApplesLib;
using HumansLib;
using ConsoleMenuLib;
using Lab6Task1;
using Lab6Task2;
using Lab6Task3;

using System.Text;

namespace MainProg;

internal static class MainProg
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        ConsoleMenu.LabNumber = 6;
        ConsoleMenu.SymbolFiller = '+';
        ConsoleMenu.LabTasks = new List<StringBuilder>
            {
                new StringBuilder("Создать однородную коллекцию List<T>"),
                new StringBuilder("Создать разнородную коллекцию List<T> по теме \"человек\""),
                new StringBuilder("Ввод-вывод хэш-таблицы по теме \"человек\"")
            };
        ConsoleMenu.Init();

        while (true)
        {
            Console.Clear();
            ConsoleMenu.WriteMenu();

            string? choosedTaskNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosedTaskNumber))
                continue;

            switch (choosedTaskNumber)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
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