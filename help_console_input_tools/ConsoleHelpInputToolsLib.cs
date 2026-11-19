using ConsoleMenuLib;

namespace ConsoleHelpInputToolsLib;

public class Help
{
    public static int? GetIndexOfVictim()
    {
        ConsoleMenu.WriteFiller();
        Console.Write("| Введите номер жертвы из архива: ");

        string? input = Console.ReadLine();

        if (input is null)
            return null;

        if (int.TryParse(input, out int number))
            return number - 1;
        else
            return -1;
    }

    public static string? GetVictimDescriptions()
    {
        Console.Write("| Введите описание санкции, примененной к жертве: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    public static string? GetVictimAdress()
    {
        Console.Write("| Введите адрес жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    public static int? GetVictimAge()
    {
        Console.Write("| Введите возраст жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out int age))
            return age;
        else
            return -1;
    }

    public static string? GetVictimName()
    {
        ConsoleMenu.WriteFiller();
        Console.Write("| Введите ФИО жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    public static int? GetApplesCount()
    {
        Console.Write(" | Введите кол-во ябл. : ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out int applesCount))
            return applesCount;
        else
            return -1;
    }

    public static int? GetBucketNumber()
    {
        ConsoleMenu.WriteFiller();
        Console.Write(" | Введите № корзинки: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out int numberBucket))
            return numberBucket;
        else
            return -1;
    }
}
