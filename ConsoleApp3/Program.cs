using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Program primer = new Program();

        //Nomer 1.1 
        Console.Write("1.1 Введите число: ");
        string input = Console.ReadLine();

        input = input.Replace(',', '.');

        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = "."
        };

        double x = Double.Parse(input, numberFormatInfo);
        double FractionResult = primer.Fraction(x);
        Console.WriteLine($"Дробная часть: {FractionResult}");


        //Nomer 1.3
        Console.WriteLine("1.3 Введите цифру: ");
        char charInput = Console.ReadKey().KeyChar;
        Console.WriteLine();  
        int charToNumResult = primer.CharToNum(charInput);
        Console.WriteLine($"Результат: {charToNumResult}");


        //Nomer 1.5
        Console.WriteLine("1.5 Введите число: ");
        string input2 = Console.ReadLine();
        int dvuznach = Convert.ToInt32(input2);
        bool is2DigitsResult = primer.is2Digits(dvuznach);
        Console.WriteLine(is2DigitsResult);

        //Nomer 1.7
        Console.WriteLine("1.7 Введите число a: ");
        string DiapozonAinput = Console.ReadLine();
        int DiapozonA = Convert.ToInt32(DiapozonAinput);

        Console.WriteLine("Введите число b: ");
        string DiapozonBinput = Console.ReadLine();
        int DiapozonB = Convert.ToInt32(DiapozonBinput);

        Console.WriteLine("Введите число num: ");
        string DiapozonNUMinput = Console.ReadLine();
        int DiapozonNUM = Convert.ToInt32(DiapozonNUMinput);

        int min = Math.Min(DiapozonA, DiapozonB);
        int max = Math.Max(DiapozonA, DiapozonB);

        bool isInRangeResult = primer.isInRange(min, max, DiapozonNUM);
        Console.WriteLine(isInRangeResult);

        //Nomer 1.9
        Console.WriteLine("1.9 Введите число a: ");
        string isEqualAinput = Console.ReadLine();
        int isEqualA = Convert.ToInt32(isEqualAinput);

        Console.WriteLine("Введите число b: ");
        string isEqualBinput = Console.ReadLine();
        int isEqualB = Convert.ToInt32(isEqualBinput);

        Console.WriteLine("Введите число c: ");
        string isEqualCinput = Console.ReadLine();
        int isEqualC = Convert.ToInt32(isEqualCinput);

        bool isEqualResult = primer.isEqual(isEqualA, isEqualB, isEqualC);
        Console.WriteLine(isEqualResult);

        //Nomer 2.1
        Console.WriteLine("2.1 Введите число: ");
        string Absinput = Console.ReadLine();
        int Abs = Convert.ToInt32(Absinput);

        int AbsResult = primer.abs(Abs);
        Console.WriteLine(AbsResult);

        //Nomer 2.3
        Console.WriteLine("2.3 Введите число: ");
        string is35input = Console.ReadLine();
        int is35 = Convert.ToInt32(is35input);

        bool is35result = primer.is35(is35);
        Console.WriteLine(is35result);

        //Nomer 2.5
        Console.WriteLine("2.5 Введите число x: ");
        string max3Ainput = Console.ReadLine();
        int max3A = Convert.ToInt32(max3Ainput);

        Console.WriteLine("Введите число y: ");
        string max3Binput = Console.ReadLine();
        int max3B = Convert.ToInt32(max3Binput);

        Console.WriteLine("Введите число z: ");
        string max3Cinput = Console.ReadLine();
        int max3C = Convert.ToInt32(max3Cinput);

        int max3Result = primer.max3(max3A, max3B, max3C);
        Console.WriteLine(max3Result);

        //Nomer 2.7 
        Console.WriteLine("2.7 Введите число x: ");
        string sum2Ainput = Console.ReadLine();
        int sum2A = Convert.ToInt32(sum2Ainput);

        Console.WriteLine("Введите число y: ");
        string sum2Binput = Console.ReadLine();
        int sum2B = Convert.ToInt32(sum2Binput);

        int sum2Result = primer.sum2(sum2A, sum2B);
        Console.WriteLine(sum2Result);

        //Nomer 2.9
        Console.WriteLine("2.9 Введите номер дня недели: ");
        string dayinput = Console.ReadLine();
        int day1 = Convert.ToInt32(dayinput);

        string dayResult = primer.day(day1);
        Console.WriteLine(dayResult);

        //Nomer 3.1
        Console.WriteLine("3.1 Введите число: ");
        string listnumsinput = Console.ReadLine();
        int listnums = Convert.ToInt32(listnumsinput);
        string listnumsresult = primer.listNums(listnums);
        Console.WriteLine(listnumsresult);

        //Nomer 3.3
        Console.WriteLine("3.3 Введите число: ");
        string chetinput = Console.ReadLine();
        int chet = Convert.ToInt32(chetinput);
        string chetresult = primer.chet(chet);
        Console.WriteLine(chetresult);

        //Nomer 3.5 
        Console.WriteLine("3.5 Введите число: ");
        string numLeninput = Console.ReadLine();
        int numLen = Convert.ToInt32(numLeninput);
        int numLenresult = primer.numLen(numLen);
        Console.WriteLine(numLenresult);

        //Nomer 3.7
        Console.WriteLine("3.7 Введите размер квадрата: ");
        string squareinpt = Console.ReadLine();
        int square = Convert.ToInt32(squareinpt);
        primer.square(square);

        //Nomer 3.9
        Console.WriteLine("3.9 Введите высоту треугольника: ");
        string triangleinpt = Console.ReadLine();
        int triangle = Convert.ToInt32(triangleinpt);
        primer.rightTriangle(triangle);

        //Nomer 4.1
        Console.WriteLine("4.1 Введите элементы массива через пробел: ");
        string arrinput = Console.ReadLine();
        int[] Arr = Array.ConvertAll(arrinput.Split(' '), int.Parse);
        Console.WriteLine("Введите число, индекс первого вхождения которого хотите найти: ");
        string arrCinput = Console.ReadLine();
        int arrChislo = Convert.ToInt32(arrCinput);
        int arrresult = primer.findFirst(Arr, arrChislo);
        Console.WriteLine(arrresult);

        //Nomer 4.3
        Console.WriteLine("4.3 Введите элементы массива через пробел: ");
        string absarrinput = Console.ReadLine();
        int[] absArr = Array.ConvertAll(absarrinput.Split(' '), int.Parse);
        int absarrresult = primer.maxAbs(absArr);
        Console.WriteLine(absarrresult);

        //Nomer 4.5 
        Console.WriteLine("4.5 Введите элементы массива через пробел: ");
        string addarrinput = Console.ReadLine();
        int[] adarr = Array.ConvertAll(addarrinput.Split(' '), int.Parse);

        Console.WriteLine("Введите элементы вставляемого массива через пробел: ");
        string adarrinsinput = Console.ReadLine();
        int[] adarrins = Array.ConvertAll(adarrinsinput.Split(' '), int.Parse);

        Console.WriteLine("Введите позицию, на которую хотите вставить новый массив: ");
        string posinput = Console.ReadLine();
        int pos = Convert.ToInt32(posinput);


        int[] addresult = primer.add(adarr, adarrins, pos);


        Console.WriteLine(string.Join(", ", addresult));

        //Nomer 4.7
        Console.WriteLine("4.7 Введите элементы массива через пробел: ");
        string revarrinput = Console.ReadLine();
        int[] revarr = Array.ConvertAll(revarrinput.Split(' '), int.Parse);
        int[] revarrresult = primer.reverseBack(revarr);
        Console.WriteLine(string.Join(" ", revarrresult));

        //Nomer 4.9 
        Console.WriteLine("4.9 Введите элементы массива через пробел: ");
        string findallinput = Console.ReadLine();
        int[] findall = Array.ConvertAll(findallinput.Split(' '), int.Parse);
        
        Console.WriteLine("Введите число, индексы вхождения которого хотите найти: ");
        string findallCinput = Console.ReadLine();
        int findallC = Convert.ToInt32(findallCinput);
        int[] findallresult = primer.findAll(findall, findallC);
        Console.WriteLine(string.Join(" ", findallresult));

    }

    //Nomer 1.1
    public double Fraction(double x)
    {
        double cel_c = Math.Floor(x);
        double drob_c = x - cel_c;
        return drob_c;
    }

    //Nomer 1.3
    public int CharToNum(char x)
    {
        return x - '0';
    }

    //Nomer 1.5
    public bool is2Digits(int x)
    {
        if (x < 100 && x >= 10)
        {
            return true;
        }
        else
            return false;
    }

    //Nomer 1.7
    public bool isInRange(int a, int b, int num)
    {
        return num >= a && num <= b;
    }

    //Nomer 1.9
    public bool isEqual(int a, int b, int c)
    {
        return (a == b) && (b == c) && (c == a); 
    }

    //Nomer 2.1
    public int abs(int x)
    {
        return Math.Abs(x);
    }

    //Nomer 2.3
    public bool is35(int x)
    {
        if (x % 3 == 0 && x % 5 == 0)
        {
            return false;
        }  
        else
        {
            return x % 3 == 0 || x % 5 == 0;
        }
        
    }

    //Nomer 2.5
    public int max3(int x, int y, int z)
    {
        int max = x>y ? x : y;
        return max > z ? max : z;
    }

    //Nomer 2.7 
    public int sum2(int x, int y)
    {
        if ((10 <= (x + y)) && (19 >= (x + y)))
        { 
            return 20; 
        }
        else
        {
            return x + y;
        }
    }

    //Nomer 2.9
    public string day(int x)
    {
        switch (x)
        {
            case (1):
                return "понедельник";
            case (2):
                return "вторник";
            case (3):
                return "среда";
            case (4):
                return "четверг";
            case (5):
                return "пятница";
            case (6):
                return "суббота";
            case (7):
                return "воскресенье";
            default:
                return "это не день недели";
        }

    }

    //Nomer 3.1
    public string listNums(int x)
    {
        string[] numbers = new string[x+1];
        for (int i = 0; i<=x; i++)
        {
            numbers[i] = i.ToString();

        }
        return string.Join(" ", numbers);
    }

    //Nomer 3.3
    public string chet(int x)
    {
        string[] numbers = new string[x + 1];
        for (int i = 0; i <= x / 2; i++)
        {

            numbers[i] = (i*2).ToString();
            
        }
        return string.Join(" ", numbers);
    }

    //Nomer 3.5 
    public int numLen(long x)
    {
        if (x < 0)
        {
            x = -x; 
        }

        if (x == 0)
        {
            return 1;
        }
        int count = 0;

        while (x > 0)
        {
            count++;
            x /= 10;
        }
        return count;
    }

    //Nomer 3.7
    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }

    //Nomer 3.9
    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.Write(new string(' ', x - i));
                
            Console.WriteLine(new string('*', i));
        }

    }

    //Nomer 4.1
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }

        }
        return -1;
    }

    //Nomer 4.3
    public int maxAbs(int[] arr)
    {
        int Max = arr[0];
        for (int i = 1; i < arr.Length; ++i)
        {
            if (Math.Abs(arr[i]) > Math.Abs(Max))
            {
                Max = arr[i];
            }
        }
        return Max;
    }

    //Nomer 4.5
    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] newArr = new int[arr.Length + ins.Length];

        Array.Copy(arr, 0, newArr, 0, pos);

        Array.Copy(ins, 0, newArr, pos, ins.Length);

        Array.Copy(arr, pos, newArr, pos + ins.Length, arr.Length - pos);

        return newArr;
    }

    //Nomer 4.7
    public int[] reverseBack(int[] arr)
    {
        int[] revArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            revArr[i] = arr[arr.Length - 1 - i];
        }
        return revArr;
    }

    //Nomer 4.9
    public int[] findAll(int[] arr, int x)
    {
        int countindex = 0 ;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                countindex++;
            }

        }

        int[] indexArr = new int[countindex];
        int index = 0;

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