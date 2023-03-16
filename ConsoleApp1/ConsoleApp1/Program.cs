//Найти максимальный элемент одномерного массива
//int[] array = { 8, -1, 4, 16, -5, 3 };
//int max = array[0];int indexmax = 0;
//for(int i=0;i<array.Length; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i]; indexmax = i;
//    }
//}
//Console.WriteLine($"max={max} indexmax={indexmax}");

// 3 zadanie

int[] array = { 8, -1, 4, 16, -5, 3 };
int min = array[0]; int indexmin = 0;
int max = array[0]; int indexmax = 0;
for (int i = 0; i < array.Length; i++)
{  
    if (array[i] < min)
    {
        min = array[i]; indexmin = i;
    }
    if (array[i] > max)
    {
        max = array[i]; indexmax = i;
    }
}
Console.WriteLine($"min={min} indexmin={indexmin}");
Console.WriteLine($"max={max} indexmax={indexmax}");

//Задача 4
//int[] rubleRates = new int[28];
//Random random = new Random();
//for (int i = 0; i < 28; i++)
//{
//    rubleRates[i] = random.Next(50, 100);
//}
//double averageRate = rubleRates.Average();
//int maxRate = rubleRates.Max();
//int maxRateIndex = Array.IndexOf(rubleRates, maxRate) + 1; 
//int minRate = rubleRates.Min();
//int minRateIndex = Array.IndexOf(rubleRates, minRate) + 1;
//Console.WriteLine($"Средний курс рубля: {averageRate:F2}");
//Console.WriteLine($"Максимальный курс рубля: {maxRate} (день {maxRateIndex})");
//Console.WriteLine($"Минимальный курс рубля: {minRate} (день {minRateIndex})");
