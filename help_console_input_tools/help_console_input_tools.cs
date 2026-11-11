namespace help_console_input_tools;

public class Help
{
    public static int? GetIndexOfVictim()
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

        int age;
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;

        if (int.TryParse(input, out age))
            return age;
        else
            return -1;
    }

    public static string? GetVictimName()
    {
        Console.WriteLine("+----------------------------------------------------------...+");
        Console.Write("| Введите ФИО жертвы: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return null;
        return input;
    }

    public static int? GetApplesCount()
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

    public static int? GetBucketNumber()
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
}
