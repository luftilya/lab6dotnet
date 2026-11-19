using ConsoleMenuLib;

using System.Collections;

namespace Lab6Task3;

public class Task3
{
    public static void Run()
    {
        Hashtable humansHt = new();
        humansHt["Дом Колотушкина"] = "Пушкин";

        while (true)
        {
            Console.Clear();
            ConsoleMenu.WriteTask(3);
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLine("Жители города Глупова живут по разным адресам.");
            ConsoleMenu.WriteLine("Вам предстоит провести перепись населения");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLine("Прозвище, адрес");
            ConsoleMenu.WriteFiller();

            if (humansHt.Count == 0)
                ConsoleMenu.WriteLine("никого не записано. Может быть, город вымер?..");
            else
                foreach (var adress in humansHt.Keys)
                    ConsoleMenu.WriteLine($"{humansHt[adress]} живёт по адресу {adress}");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLine("1) Добавить жителя в хэш-таблицу");
            ConsoleMenu.WriteLine("2) Убрать жителя из хэш-таблицы");
            ConsoleMenu.WriteLine("3) Поменять жителя по адресу");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.Write("Введите цифру действия: ");

            string? choosedTaskNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosedTaskNumber))
                break;

            switch (choosedTaskNumber)
            {
                case "1":
                    {
                        ConsoleMenu.WriteFiller();
                        ConsoleMenu.Write("Введите прозвище жителя: ");

                        string? name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        ConsoleMenu.Write("Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        humansHt[adress] = name;
                        ConsoleMenu.WriteLine("Вы успешно добавили жителя в хэш-таблицу.");
                        ConsoleMenu.WriteContinue();
                    }
                    break;
                case "2":
                    {
                        if (humansHt.Count == 0)
                            break;

                        ConsoleMenu.WriteFiller();
                        ConsoleMenu.Write("Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        if (!humansHt.ContainsKey(adress))
                            break;

                        humansHt.Remove(adress);
                        ConsoleMenu.WriteLine("Вы успешно удалили жителя из хэш-таблицы.");
                        ConsoleMenu.WriteContinue();
                    }
                    break;
                case "3":
                    {
                        if (humansHt.Count == 0)
                            break;

                        ConsoleMenu.WriteFiller();
                        ConsoleMenu.Write("Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        if (!humansHt.ContainsKey(adress))
                            break;

                        ConsoleMenu.Write("Введите новое прозвище жителя: ");

                        string? name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        humansHt[adress] = name;
                        ConsoleMenu.WriteLine("Вы успешно поменяли жителя в хэш-таблице.");
                        ConsoleMenu.WriteContinue();
                    }
                    break;
            }
        }
    }
}