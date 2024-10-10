using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] ins = { 7, 8, 9 };
        int pos = 3;

        int[] result = add(arr, ins, pos);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", result));  // Вывод: 1, 2, 3, 7, 8, 9, 4, 5
    }

    public static int[] add(int[] arr, int[] ins, int pos)
    {
        // Создаем новый массив, длина которого равна сумме длины двух массивов
        int[] newArr = new int[arr.Length + ins.Length];

        // Копируем элементы из arr до позиции pos
        Array.Copy(arr, 0, newArr, 0, pos);

        // Копируем элементы из ins на позицию pos
        Array.Copy(ins, 0, newArr, pos, ins.Length);

        // Копируем оставшиеся элементы из arr после позиции pos
        Array.Copy(arr, pos, newArr, pos + ins.Length, arr.Length - pos);

        return newArr;
    }
}
