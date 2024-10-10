using System;

class Program
{
    static void Main()
    {
        Program primer = new Program();

        Console.WriteLine("Введите элементы массива через пробел: ");
        string findallinput = Console.ReadLine();
        int[] findall = Array.ConvertAll(findallinput.Split(' '), int.Parse);

        Console.WriteLine("Введите число, индексы вхождения которого хотите найти: ");
        string findallCinput = Console.ReadLine();
        int findallC = Convert.ToInt32(findallCinput);

        int[] findallresult = primer.findAll(findall, findallC);
        if (findallresult.Length > 0)
        {
            Console.WriteLine("Индексы вхождения: " + string.Join(" ", findallresult));
        }
        else
        {
            Console.WriteLine("Число не найдено в массиве.");
        }
    }

    public int[] findAll(int[] arr, int x)
    {
        // Считаем количество вхождений числа x
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        // Если вхождений нет, возвращаем пустой массив
        if (count == 0)
        {
            return new int[0];
        }

        // Создаем массив для индексов
        int[] indexArr = new int[count];
        int index = 0;

        // Заполняем массив индексами вхождений числа x
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                indexArr[index] = i;
                index++;
            }
        }

        return indexArr;
    }
}
