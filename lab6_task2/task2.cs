using humans;
using help_console_input_tools;

namespace lab6_task2;

public class task2
{
    public static void Run()
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

            string? choosed_task = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosed_task))
                break;

            switch (choosed_task)
            {
                case "1":
                    {
                        string? name = Help.GetVictimName();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        int? age = Help.GetVictimAge();

                        if (age is null || age < 0)
                            break;

                        string? adress = Help.GetVictimAdress();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        string? descriptions = Help.GetVictimDescriptions();

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
                        int? n = Help.GetIndexOfVictim() - 1;

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
                        int? n = Help.GetIndexOfVictim() - 1;

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
    }
}
