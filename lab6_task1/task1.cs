using buckets_with_apples;
using help_console_input_tools;

namespace lab6_task1;

public class task1
{
    public static void Run()
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

            string? choosed_task = Console.ReadLine();

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
                        int? n = Help.GetBucketNumber();

                        if (n is null || n < 1 || n > buckets.Count)
                            break;

                        buckets.RemoveAt(n.Value - 1);
                        Console.WriteLine($"/ Вы выкинули кор. № {n}! Нажмите Enter для продолжения.");
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        int? n = Help.GetBucketNumber();

                        if (n is null || n < 1 || n > buckets.Count)
                            break;

                        int? m = Help.GetApplesCount();

                        if (m is null)
                            break;

                        buckets[n.Value - 1].AddApples(m.Value);
                        Console.WriteLine($"/ Вы положили {m} ябл. в кор. № {n}! Нажмите Enter для продолжения.");
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        int? n = Help.GetBucketNumber();

                        if (n is null || n < 1 || n > buckets.Count)
                            break;

                        int? m = Help.GetApplesCount();

                        if (m is null || m.Value > buckets[n.Value - 1].GetApplesCount())
                            break;

                        buckets[n.Value - 1].RemoveApples(m.Value);
                        Console.WriteLine($"/ Вы выложили {m} ябл. из кор. № {n}! Нажмите Enter для продолжения.");
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
}
