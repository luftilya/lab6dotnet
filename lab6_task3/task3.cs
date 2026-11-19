using System.Collections;

namespace Lab6Task3;

public class Task3
{
    public static void Run()
    {
        var humans_ht = new Hashtable();
        humans_ht["Дом Колотушкина"] = "Пушкина";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("/ Ввод-вывод хэш-таблицы по теме \"человек\"...\\");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Жители города Глупова живут по разным адресам.\n| Вам предстоит провести перепись населения");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Прозвище, адрес");
            Console.WriteLine("+----------------------------------------------+");

            if (humans_ht.Count == 0)
                Console.WriteLine("никого не записано. Может быть, город вымер?..");
            else
                foreach (var adress in humans_ht.Keys)
                    Console.WriteLine(humans_ht[adress] + " живёт по адресу " + adress);
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| 1) Добавить жителя в хэш-таблицу");
            Console.WriteLine("| 2) Убрать жителя из хэш-таблицы");
            Console.WriteLine("| 3) Поменять жителя по адресу");
            Console.WriteLine("+----------------------------------------------+");
            Console.Write("\\ Выберите цифру действия: ");

            string? choosed_task = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosed_task))
                break;

            switch (choosed_task)
            {
                case "1":
                    {
                        Console.WriteLine("/----------------------------------------------\\");
                        Console.Write("| Введите прозвище жителя: ");

                        string? name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        Console.Write("| Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        humans_ht[adress] = name;
                        Console.WriteLine("\\ Вы успешно добавили жителя в хэш-таблицу. Для продолжения нажмите Enter.");
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    {
                        if (humans_ht.Count == 0)
                            break;

                        Console.WriteLine("/----------------------------------------------\\");
                        Console.Write("| Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        if (!humans_ht.ContainsKey(adress))
                            break;

                        humans_ht.Remove(adress);
                        Console.WriteLine("\\ Вы успешно удалили жителя из хэш-таблицы. Для продолжения нажмите Enter.");
                        Console.ReadKey();
                    }
                    break;
                case "3":
                    {
                        if (humans_ht.Count == 0)
                            break;

                        Console.WriteLine("/----------------------------------------------\\");
                        Console.Write("| Введите адрес жителя: ");

                        string? adress = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        if (!humans_ht.ContainsKey(adress))
                            break;

                        Console.Write("| Введите новое прозвище жителя: ");

                        string? name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        humans_ht[adress] = name;
                        Console.WriteLine("\\ Вы успешно поменли жителя в хэш-таблице. Для продолжения нажмите Enter.");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
