using buckets_with_apples;
using humans;
using System.Collections;
using System.Xml.Linq;
namespace mainprog;

internal static class Program
{
    static int? GetIndexOfVictim()
    {
        int n;
        string? input;
        Console.WriteLine("+----------------------------------------------------------...+");
        Console.Write("\\ Введите номер жертвы из архива: ");

        input = Console.ReadLine();

        if (input is null)
            return null;

        if (int.TryParse(input, out n))
            return n;
        else
            return -1;
    }

    static string? GetVictimDescriptions()
    {
        Console.Write("| Введите описание санкции, примененной к жертве: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    static string? GetVictimAdress()
    {
        Console.Write("| Введите адрес жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    static int? GetVictimAge()
    {
        Console.Write("| Введите возраст жертвы: ");

        int age;
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out age))
            return age;
        else
            return -1;
    }

    static string? GetVictimName()
    {
        Console.WriteLine("+----------------------------------------------------------...+");
        Console.Write("| Введите ФИО жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    static int? GetApplesCount()
    {
        int m;
        string? input;

        Console.Write(" | Введите кол-во ябл. : ");

        input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out m))
            return m;
        else
            return -1;
    }

    static int? GetBucketNumber()
    {
        int n;
        string? input;

        Console.WriteLine("\\-------------------------------------.../");
        Console.Write(" | Введите № корзинки: ");

        input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out n))
            return n;
        else
            return -1;
    }

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
                    {
                        var buckets = new List<BucketWithApples>();
                        while (true)
                        {

                            Console.Clear();
                            Console.WriteLine("/ Создать однородную коллекцию List<T>...\\");
                            Console.WriteLine("+-------------------------------------...+");
                            Console.WriteLine("| Вы оказались на центральном рынке\n| с корзинками для яблок\n| и непременно хотите их заполнить.");
                            Console.WriteLine("+-------------------------------------...+");
                            Console.WriteLine("| 1) принести ещё одну корзинку ^^");
                            Console.WriteLine("| 2) выкинуть одну корзинку >:(");
                            Console.WriteLine("| 3) положить яблочки в корзинку :)");
                            Console.WriteLine("| 4) выложить яблочки из корзинки :(");
                            Console.WriteLine("\\-------------------------------------.../");
                            Console.Write("| Корзинки: ");

                            if (buckets.Count == 0)
                                Console.Write("нет корзинок :(");
                            else
                                for (int i = 1; i <= buckets.Count; i++)
                                    Console.Write($"К№{i}: {buckets[i - 1].GetApplesCount()} ябл.; ");

                            Console.WriteLine("\n/-------------------------------------...\\");
                            Console.Write("| Выберите цифру действия: ");

                            choosed_task = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(choosed_task))
                                break;

                            switch (choosed_task)
                            {
                                case "1":
                                    {
                                        buckets.Add(new BucketWithApples());
                                        break;
                                    }
                                case "2":
                                    {
                                        int? n = GetBucketNumber();

                                        if (n is null || n < 1 || n > buckets.Count)
                                            break;

                                        buckets.RemoveAt(n.Value - 1);
                                        Console.WriteLine($"/ Вы выкинули кор. № {n}! Нажмите Enter для продолжения.");
                                        Console.ReadKey();
                                        break;
                                    }
                                case "3":
                                    {
                                        int? n = GetBucketNumber();

                                        if (n is null || n < 1 || n > buckets.Count)
                                            break;

                                        int? m = GetApplesCount();

                                        if (m is null)
                                            break;

                                        buckets[n.Value - 1].AddApples(m.Value);
                                        Console.WriteLine($"/ Вы положили {m} ябл. в кор. № {n}! Нажмите Enter для продолжения.");
                                        Console.ReadKey();
                                        break;
                                    }
                                case "4":
                                    {
                                        int? n = GetBucketNumber();

                                        if (n is null || n < 1 || n > buckets.Count)
                                            break;

                                        int? m = GetApplesCount();

                                        if (m is null || m.Value > buckets[n.Value - 1].GetApplesCount())
                                            break;

                                        buckets[n.Value - 1].RemoveApples(m.Value);
                                        Console.WriteLine($"/ Вы выложили {m} ябл. из кор. № {n}! Нажмите Enter для продолжения.");
                                        Console.ReadKey();
                                        break;
                                    }
                            }
                        }
                        break;
                    }
                case "2":
                    {
                        var humans = new List<Humans>();
                        humans.Add(new Humans("Зеленев Илья Николаевич", 18, "Политехнический пер., 4", "ст. 58 ук рсфср"));

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("/ Создать разнородную коллекцию List<T> по теме \"человек\"...\\");
                            Console.WriteLine("+----------------------------------------------------------...+");
                            Console.WriteLine("| Вы являетесь архивариусом городского архива\n| жертв политических репрессий. Вам нужно внести сведения\n| жертв: ФИО, ВОЗРАСТ, АДРЕС РОЖДЕНИЯ, ПОДРОБНОСТИ САНКЦИИ");
                            Console.WriteLine("+----------------------------------------------------------...+");
                            Console.WriteLine("| 1) Добавить жертву в архив :(");
                            Console.WriteLine("| 2) Удалить жертву из архива :)");
                            Console.WriteLine("| 3) Изменить данные жертвы в архиве :/");
                            Console.WriteLine("+----------------------------------------------------------...+");
                            Console.WriteLine("| ФИО, возраст, адресс и описание применной санкции           |");
                            Console.WriteLine("+----------------------------------------------------------...+");

                            if (humans.Count < 0)
                                Console.WriteLine("Жертв нет! Да здравствует справедливость!");
                            else
                                for (int i = 0; i < humans.Count; i++)
                                    Console.WriteLine((i + 1) + " "
                                        + humans[i].GetName() + " "
                                        + humans[i].GetAge() + " "
                                        + humans[i].GetAdress() + " "
                                        + humans[i].GetDescriptions());
                            Console.WriteLine("+----------------------------------------------------------...+");
                            Console.Write("\\ Выберите цифру действия и нажмите Enter: ");

                            choosed_task = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(choosed_task))
                                break;

                            switch (choosed_task)
                            {
                                case "1":
                                    {
                                        string? name = GetVictimName();

                                        if (string.IsNullOrWhiteSpace(name))
                                            break;

                                        int? age = GetVictimAge();

                                        if (age is null || age < 0)
                                            break;

                                        string? adress = GetVictimAdress();

                                        if (string.IsNullOrWhiteSpace(adress))
                                            break;

                                        string? descriptions = GetVictimDescriptions();

                                        if (string.IsNullOrWhiteSpace(descriptions))
                                            break;

                                        humans.Add(new Humans(name, age.Value, adress, descriptions));

                                        Console.WriteLine("+----------------------------------------------------------...+");
                                        Console.WriteLine("\\ Вы добавили ещё одну жертву в архив. Нажмите Enter для продолжения.");
                                        Console.ReadKey();
                                    }
                                    break;
                                case "2":
                                    {
                                        int? n = GetIndexOfVictim() - 1;

                                        if (n is null || n < 0 || n >= humans.Count)
                                            break;

                                        humans.RemoveAt(n.Value);
                                        Console.WriteLine("+----------------------------------------------------------...+");
                                        Console.WriteLine("\\ Вы удалили жертву политических репрессий из архива. Нажмите Enter для продолжения.");
                                        Console.ReadKey();
                                    }
                                    break;
                                case "3":
                                    {
                                        int? n = GetIndexOfVictim() - 1;

                                        if (n is null || n < 0 || n >= humans.Count)
                                            break;

                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+----------------------------------------------------------...+");
                                            Console.WriteLine("| Вы хотите изменить архивные данные у");
                                            Console.WriteLine("| "
                                                + humans[n.Value].GetName() + " "
                                                + humans[n.Value].GetAge() + " "
                                                + humans[n.Value].GetAdress() + " "
                                                + humans[n.Value].GetDescriptions());
                                            Console.WriteLine("+----------------------------------------------------------...+");
                                            Console.WriteLine("| 1) Изменить ФИО");
                                            Console.WriteLine("| 2) Изменить возраст");
                                            Console.WriteLine("| 3) Изменить адрес");
                                            Console.WriteLine("| 4) Изменить применённую санкцию");
                                            Console.WriteLine("+----------------------------------------------------------...+");
                                            Console.WriteLine("\\ Выберите цифру действия: ");

                                            choosed_task = Console.ReadLine();

                                            if (string.IsNullOrWhiteSpace(choosed_task))
                                                break;

                                            switch (choosed_task)
                                            {
                                                case "1":
                                                    {
                                                        Console.WriteLine("/----------------------------------------------------------...+");
                                                        Console.WriteLine("| Введите новое ФИО: ");

                                                        string? input = Console.ReadLine();

                                                        if (string.IsNullOrWhiteSpace(input))
                                                            break;

                                                        humans[n.Value].SetName(input);
                                                        Console.WriteLine("\\ Вы изменили ФИО жерты. Нажмите Enter для продолжения.");
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "2":
                                                    {
                                                        Console.WriteLine("/----------------------------------------------------------...+");
                                                        Console.WriteLine("| Введите новый возраст: ");

                                                        string? input = Console.ReadLine();

                                                        if (string.IsNullOrWhiteSpace(input))
                                                            break;

                                                        if (int.TryParse(input, out int age))
                                                            humans[n.Value].SetAge(age);
                                                        Console.WriteLine("\\ Вы изменили возраст жерты. Нажмите Enter для продолжения.");
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "3":
                                                    {
                                                        Console.WriteLine("/----------------------------------------------------------...+");
                                                        Console.WriteLine("| Введите новый адрес: ");

                                                        string? input = Console.ReadLine();

                                                        if (string.IsNullOrWhiteSpace(input))
                                                            break;

                                                        humans[n.Value].SetAdress(input);
                                                        Console.WriteLine("\\ Вы изменили адрес жерты. Нажмите Enter для продолжения.");
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "4":
                                                    {
                                                        Console.WriteLine("/----------------------------------------------------------...+");
                                                        Console.WriteLine("| Введите новую применённую санкцию: ");

                                                        string? input = Console.ReadLine();

                                                        if (string.IsNullOrWhiteSpace(input))
                                                            break;

                                                        humans[n.Value].SetDescriptions(input);
                                                        Console.WriteLine("\\ Вы изменили примененённую санкцию жерты. Нажмите Enter для продолжения.");
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    }
                case "3":
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

                            choosed_task = Console.ReadLine();

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
                        break;
                    }
                case "4":
                    Application.Run(new FormOf1());
                    break;
                case "5":
                    Application.Run(new FormOf2());
                    break;
                case "6":
                    Application.Run(new FormOf3());
                    break;
                default:
                    {
                        Console.WriteLine("/----------------------------------------------------------------------------------------...");
                        Console.WriteLine($"| ОШИБКА! Вы ввели \"{choosed_task}\", этого не предоставлено в меню. Попробуйте ещё раз, нажав Enter.");
                        Console.WriteLine("\\----------------------------------------------------------------------------------------/");
                    }
                    break;
            }
        }
    }
}