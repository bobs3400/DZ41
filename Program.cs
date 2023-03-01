Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int KolNum(int[] mass)
{   
    int n = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] > 0)
        n++;
    }
    return n;
}
if(KolNum(baseArray) > 0)
{
    Console.WriteLine($"В данном массиве {KolNum(baseArray)} чисел больше 0");
}
else
{
    Console.WriteLine($"В данном массиве нет чисел больше 0");
}