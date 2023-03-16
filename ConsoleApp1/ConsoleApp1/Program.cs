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
