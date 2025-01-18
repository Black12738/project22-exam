using System;
using System.Collections.Generic;

class Program
{
    //این تابع یک آرایه عدد صحیح را به عنوان ورودی می‌گیرد.
    static List<(int, int)> FindSubarraysWithZeroSum(int[] array)
    {
        // لیست برای ذخیره اندیس شروع و پایان زیرآرایه‌هایی که مجموعشان صفر است
        List<(int, int)> result = new List<(int, int)>();

        // دیکشنری برای ذخیره مجموع تجمعی و موقعیت‌های مربوطه
        Dictionary<int, List<int>> prefixSumMap = new Dictionary<int, List<int>>();
        int prefixSum = 0;

        // اضافه کردن مجموع صفر برای شروع
        prefixSumMap[0] = new List<int> { -1 };
        //حلقه اصلی
        for (int i = 0; i < array.Length; i++)
        {
            prefixSum += array[i];

            //ین به این معناست که بین آخرین موقعیت‌هایی که این مجموع ظاهر شده و موقعیت فعلی، مجموع عناصر صفر است.

            if (prefixSumMap.ContainsKey(prefixSum))
            {
                foreach (int startIndex in prefixSumMap[prefixSum])
                {
                    result.Add((startIndex + 1, i));
                }
            }

            if (!prefixSumMap.ContainsKey(prefixSum))
            {
                prefixSumMap[prefixSum] = new List<int>();
            }
            //اندیس فعلی را به لیست موقعیت‌های مربوط به این مجموع تجمعی اضافه می‌کنیم.
            prefixSumMap[prefixSum].Add(i);
        }
        //بازگشت نتیجه
        //در انتها، لیست زیرآرایه‌های با مجموع صفر برگردانده می‌شود.
        return result;
    }

    static void Main(string[] args)
    {
        //یک آرایه نمونه تعریف می‌شود.
        int[] array = { 3, 4, -7, 1, 2, -1, 4, -2, -2 };
        //تابع FindSubarraysWithZeroSum برای پیدا کردن زیرآرایه‌های با مجموع صفر فراخوانی می‌شود.
        List<(int, int)> subarrays = FindSubarraysWithZeroSum(array);


        //اگر لیست زیرآرایه‌ها خالی نباشد، موقعیت شروع و پایان هر زیرآرایه با مجموع صفر چاپ می‌شود.
        //اگر لیست خالی باشد، پیام "هیچ زیرآرایه‌ای یافت نشد" نمایش داده می‌شود.
        if (subarrays.Count > 0)
        {
            Console.WriteLine("Subarrays with zero sum:");
            foreach (var (start, end) in subarrays)
            {
                Console.WriteLine($"Start: {start}, End: {end}");
            }
        }
        else
        {
            Console.WriteLine("No subarrays with zero sum found.");
        }
    }
}