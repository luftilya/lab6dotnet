using BucketsWithApplesLib;
using ConsoleMenuLib;
using ConsoleHelpInputToolsLib;

namespace Lab6Task1;

public class Task1
{
    public static void Run()
    {
        List<BucketWithApples> buckets = new();

        while (true)
        {

            Console.Clear();
            ConsoleMenu.WriteTask(1);
            ConsoleMenu.WriteLineContent("Вы оказались на центральном рынке");
            ConsoleMenu.WriteLineContent("с корзинками для яблок");
            ConsoleMenu.WriteLineContent("и непременно хотите их заполнить.");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteLineContent("1) принести ещё одну корзинку ^^");
            ConsoleMenu.WriteLineContent("2) выкинуть одну корзинку >:(");
            ConsoleMenu.WriteLineContent("3) положить яблочки в корзинку :)");
            ConsoleMenu.WriteLineContent("4) выложить яблочки из корзинки :(");
            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteContent("Корзинки: ");

            if (buckets.Count == 0)
                Console.Write("нет корзинок :(");
            else
                for (int i = 1; i <= buckets.Count; i++)
                    Console.Write($"К№{i}: {buckets[i - 1].GetApplesCount()} ябл.; ");
            Console.WriteLine();

            ConsoleMenu.WriteFiller();
            ConsoleMenu.WriteContent("Введите цифру действия: ");

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
                        int? bucketNumber = Help.GetBucketNumber();

                        if (bucketNumber is null
                            || bucketNumber < 1
                            || bucketNumber > buckets.Count)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLineContent(
                                "Ошибка! Вы ввели неправильное значение или не ввели ничего. Попробуйте ещё раз");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        buckets.RemoveAt(bucketNumber.Value - 1);
                        ConsoleMenu.WriteLineContent(
                            $"Вы выкинули кор. № {bucketNumber}!");
                        ConsoleMenu.WriteContinue();
                        break;
                    }
                case "3":
                    {
                        int? bucketNumber = Help.GetBucketNumber();

                        if (bucketNumber is null
                            || bucketNumber < 1
                            || bucketNumber > buckets.Count)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLineContent(
                                "Ошибка! Вы ввели неправильное значение или не ввели ничего. Попробуйте ещё раз");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        int? applesCount = Help.GetApplesCount();

                        if (applesCount is null)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLineContent(
                                "Ошибка! Вы ввели неправильное значение или не ввели ничего. Попробуйте ещё раз");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        buckets[bucketNumber.Value - 1].AddApples(applesCount.Value);
                        ConsoleMenu.WriteLineContent(
                            $"Вы положили {applesCount} ябл. в кор. № {bucketNumber}!");
                        ConsoleMenu.WriteContinue();
                        break;
                    }
                case "4":
                    {
                        int? bucketNumber = Help.GetBucketNumber();

                        if (bucketNumber is null
                            || bucketNumber < 1
                            || bucketNumber > buckets.Count)
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLineContent(
                                "Ошибка! Вы ввели неправильное значение или не ввели ничего. Попробуйте ещё раз");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        int? applesCount = Help.GetApplesCount();

                        if (applesCount is null
                            || applesCount.Value > buckets[bucketNumber.Value - 1].GetApplesCount())
                        {
                            ConsoleMenu.WriteFiller();
                            ConsoleMenu.WriteLineContent(
                                "Ошибка! Вы ввели неправильное значение или не ввели ничего. Попробуйте ещё раз");
                            ConsoleMenu.WriteContinue();
                            break;
                        }

                        buckets[bucketNumber.Value - 1].RemoveApples(applesCount.Value);
                        ConsoleMenu.WriteLineContent(
                            $"Вы выложили {applesCount} ябл. из кор. № {bucketNumber}!");
                        ConsoleMenu.WriteContinue();
                        break;
                    }
            }
        }
    }
}
