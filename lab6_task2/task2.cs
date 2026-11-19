using HumansLib;
using ConsoleMenuLib;
using ConsoleHelpInputToolsLib;

namespace Lab6Task2;

public class Task2
{
    public static void Run()
    {
        List<Humans> humans = new();
        humans.Add(new Humans(
            "Зеленев Илья Николаевич", 
            18, 
            "Политехнический пер., 4", 
            "ст. 58 ук рсфср"));

        while (true)
        {
            Console.Clear();
            ConsoleMenu.WriteTask(2);
            ConsoleMenu.WriteLine("Вы являетесь архивариусом городского архива");
            ConsoleMenu.WriteLine("жертв политических репрессий. Вам нужно внести сведения");
            ConsoleMenu.WriteLine("жертв: ФИО, ВОЗРАСТ, АДРЕС РОЖДЕНИЯ, ПОДРОБНОСТИ САНКЦИИ");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLine("1) Добавить жертву в архив :(");
            ConsoleMenu.WriteLine("2) Удалить жертву из архива :)");
            ConsoleMenu.WriteLine("3) Изменить данные жертвы в архиве :/");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLine("ФИО, возраст, адресс и описание применной санкции");
            ConsoleMenu.WriteFiller();

            if (humans.Count == 0)
                ConsoleMenu.WriteLine("Жертв нет! Да здравствует справедливость!");
            else
                for (int i = 0; i < humans.Count; i++)
                    ConsoleMenu.WriteLine((i + 1) + " "
                        + humans[i].Name + " "
                        + humans[i].Age + " "
                        + humans[i].Adress + " "
                        + humans[i].Descriptions);
            ConsoleMenu.WriteFiller();
            ConsoleMenu.Write("Введите цифру действия: ");

            string? choosedTaskNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choosedTaskNumber))
                break;

            switch (choosedTaskNumber)
            {
                case "1":
                    {
                        string? name = Help.GetVictimName();

                        if (string.IsNullOrWhiteSpace(name))
                            break;

                        int? age = Help.GetVictimAge();

                        if (age is null)
                            break;
                        else if (age < 0)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLine(
                                "Ошибка! Вы ввели невозможное значение возраста! Попробуйте ещё раз.");
                            ConsoleMenu.WriteContinue();
                        }
                        

                        string? adress = Help.GetVictimAdress();

                        if (string.IsNullOrWhiteSpace(adress))
                            break;

                        string? descriptions = Help.GetVictimDescriptions();

                        if (string.IsNullOrWhiteSpace(descriptions))
                            break;

                        humans.Add(new Humans(
                            name, 
                            age.Value, 
                            adress, 
                            descriptions));

                        ConsoleMenu.WriteFiller();
                        ConsoleMenu.WriteLine(
                            "Вы добавили ещё одну жертву в архив.");
                        ConsoleMenu.WriteContinue();
                    }
                    break;
                case "2":
                    {
                        int? indexOfVictim = Help.GetIndexOfVictim();

                        if (indexOfVictim is null)
                            break;
                        else if (indexOfVictim < 0 || indexOfVictim >= humans.Count)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLine(
                                "Ошибка! Вы ввели несуществующий номер жертвы. Попробуйте ещё раз.");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        humans.RemoveAt(indexOfVictim.Value);
                        ConsoleMenu.WriteFiller();
                        ConsoleMenu.WriteLine("Вы удалили жертву политических репрессий из архива.");
                        ConsoleMenu.WriteContinue();
                    }
                    break;
                case "3":
                    {
                        int? indexOfVictim = Help.GetIndexOfVictim();

                        if (indexOfVictim is null)
                            break;
                        else if (indexOfVictim < 0 || indexOfVictim >= humans.Count)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLine(
                                "Ошибка! Вы ввели несуществующий номер жертвы. Попробуйте ещё раз.");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        while (true)
                        {
                            Console.Clear();
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLine("Вы хотите изменить архивные данные у");
                            ConsoleMenu.WriteLine(
                                humans[indexOfVictim.Value].Name + " "
                                + humans[indexOfVictim.Value].Age + " "
                                + humans[indexOfVictim.Value].Adress + " "
                                + humans[indexOfVictim.Value].Descriptions);
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLine("1) Изменить ФИО");
                            ConsoleMenu.WriteLine("2) Изменить возраст");
                            ConsoleMenu.WriteLine("3) Изменить адрес");
                            ConsoleMenu.WriteLine("4) Изменить применённую санкцию");
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.Write("Выберите цифру действия: ");

                            choosedTaskNumber = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(choosedTaskNumber))
                                break;

                            switch (choosedTaskNumber)
                            {
                                case "1":
                                    {
                                        ConsoleMenu.WriteFiller();
                                        ConsoleMenu.Write("Введите новое ФИО: ");

                                        string? input = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(input))
                                            break;

                                        humans[indexOfVictim.Value].Name = input;
                                        ConsoleMenu.WriteLine("Вы изменили ФИО жерты.");
                                        ConsoleMenu.WriteContinue();
                                    }
                                    break;
                                case "2":
                                    {
                                        ConsoleMenu.WriteFiller();
                                        ConsoleMenu.Write("Введите новый возраст: ");

                                        string? input = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(input))
                                            break;

                                        if (int.TryParse(input, out int age)
                                            && age > 0)
                                        {
                                            humans[indexOfVictim.Value].Age = age;
                                            ConsoleMenu.WriteLine("Вы изменили возраст жерты.");
                                            ConsoleMenu.WriteContinue();
                                        }
                                        else
                                        {
                                            ConsoleMenu.WriteLine(
                                                $"Ошибка! Вы ввели невозможное значение возраста! Попробуйте ещё раз.");
                                            ConsoleMenu.WriteContinue();
                                        }
                                    }
                                    break;
                                case "3":
                                    {
                                        ConsoleMenu.WriteFiller();
                                        ConsoleMenu.WriteLine("Введите новый адрес: ");

                                        string? input = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(input))
                                            break;

                                        humans[indexOfVictim.Value].Adress = input;
                                        ConsoleMenu.WriteLine("Вы изменили адрес жерты.");
                                        ConsoleMenu.WriteContinue();
                                    }
                                    break;
                                case "4":
                                    {
                                        ConsoleMenu.WriteFiller();
                                        ConsoleMenu.WriteLine("Введите новую применённую санкцию: ");

                                        string? input = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(input))
                                            break;

                                        humans[indexOfVictim.Value].Descriptions = input;
                                        ConsoleMenu.WriteLine("Вы изменили примененённую санкцию жерты.");
                                        ConsoleMenu.WriteContinue();
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